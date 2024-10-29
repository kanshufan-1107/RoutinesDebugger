using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Xml;
using Microsoft.CSharp;
using System.Windows.Threading;
using SilverfishWrapper;
using System.Collections;
using Path = System.IO.Path;

namespace RoutineHelper
{
    public class InfoItem
    {
        public string Item { get; set; }
        public string Value { get; set; }
    }
    public class ActionItem
    {
        public List<ActionItem> subGroups = new List<ActionItem>();
        public float Score { get; set; }
        public string Action { get; set; }
        public string Decision { get; set; }

        public string Source { get; set; }

        public int Level { get; set; }

        public string Target { get; set; }

        public ActionItem Father { get; set; }

        public Playfield Board { get; set; }

        public IList<object> Items
        {
            get
            {
                IList<object> childNodes = new List<object>();
                foreach (var group in this.subGroups)
                    childNodes.Add(group);

                return childNodes;
            }
        }
    }

    public class XmlConfigUtil
    {
        #region 全局变量
        string _xmlPath;        //文件所在路径
        #endregion

        #region 构造函数
        /// <summary>
        /// 初始化一个配置
        /// </summary>
        /// <param name="xmlPath">配置所在路径</param>
        public XmlConfigUtil(string xmlPath)
        {
            _xmlPath = System.IO.Path.GetFullPath(xmlPath);
        }
        #endregion

        #region 公有方法
        /// <summary>
        /// 写入配置
        /// </summary>
        /// <param name="value">写入的值</param>
        /// <param name="nodes">节点</param>
        public void Write(string value, params string[] nodes)
        {
            //初始化xml
            XmlDocument xmlDoc = new XmlDocument();
            if (File.Exists(_xmlPath))
                xmlDoc.Load(_xmlPath);
            else
                xmlDoc.LoadXml("<XmlConfig />");
            XmlNode xmlRoot = xmlDoc.ChildNodes[0];

            //新增、编辑 节点
            string xpath = string.Join("/", nodes);
            XmlNode node = xmlDoc.SelectSingleNode(xpath);
            if (node == null)    //新增节点
            {
                node = makeXPath(xmlDoc, xmlRoot, xpath);
            }
            node.InnerText = value;

            //保存
            xmlDoc.Save(_xmlPath);
        }

        /// <summary>
        /// 读取配置
        /// </summary>
        /// <param name="nodes">节点</param>
        /// <returns></returns>
        public string Read(params string[] nodes)
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (File.Exists(_xmlPath) == false)
                return null;
            else
                xmlDoc.Load(_xmlPath);

            string xpath = string.Join("/", nodes);
            XmlNode node = xmlDoc.SelectSingleNode("/XmlConfig/" + xpath);
            if (node == null)
                return null;

            return node.InnerText;
        }
        #endregion

        #region 私有方法
        //递归根据 xpath 的方式进行创建节点
        static private XmlNode makeXPath(XmlDocument doc, XmlNode parent, string xpath)
        {

            // 在XPath抓住下一个节点的名称；父级如果是空的则返回
            string[] partsOfXPath = xpath.Trim('/').Split('/');
            string nextNodeInXPath = partsOfXPath.First();
            if (string.IsNullOrEmpty(nextNodeInXPath))
                return parent;

            // 获取或从名称创建节点
            XmlNode node = parent.SelectSingleNode(nextNodeInXPath);
            if (node == null)
                node = parent.AppendChild(doc.CreateElement(nextNodeInXPath));

            // 加入的阵列作为一个XPath表达式和递归余数
            string rest = String.Join("/", partsOfXPath.Skip(1).ToArray());
            return makeXPath(doc, node, rest);
        }
        #endregion
    }
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public CardDB cardDB;
        public List<Card> allCardsList;
        public BackgroundWorker searchWorker;
        public ActionItem actionItem;
        public List<ActionItem> bestActionItem = new List<ActionItem>();
        public float lastHighlightedScore = -1;
        public Dictionary<float, List<ActionItem>> actionScoreMap = new Dictionary<float, List<ActionItem>>();
        public Dictionary<string, object> playfieldActionList = new Dictionary<string, object>();
        public bool isExporting = false;
        public static Assembly compiledRoutines;

        private float bestScore;

        public float BestScore
        {
            get
            {
                return this.bestScore;
            }
            set
            {
                if (value != this.bestScore)
                {
                    this.bestScore = value;
                    NotifyPropertyChanged("BestScore");
                }
            }
        }

        private readonly string _defaultXmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Settings\Default");
        private readonly string _routineXml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Settings\Default\routine.xml");
        private readonly string _compiledAssemblies = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CompiledAssemblies");

        protected void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            LoadAssembly();
        }

        private void LoadAssembly()
        {
            if (!Directory.Exists(_defaultXmlPath))
            {
                Directory.CreateDirectory(_defaultXmlPath);
            }
            if (!Directory.Exists(_compiledAssemblies))
            {
                Directory.CreateDirectory(_compiledAssemblies);
            }

#if DEBUG1
            compiledRoutines = Assembly.Load(File.ReadAllBytes(@"..\\..\\hearthstoneRoutine\\bin\\Debug\\Silverfish.dll"));
#else
            var defaultRoutine = Path.Combine(_compiledAssemblies, "Silverfish.dll");
            if (File.Exists(defaultRoutine))
            {
                compiledRoutines = Assembly.Load(File.ReadAllBytes(defaultRoutine));
            }
            else
            {
                var compiler = new CompilerWindow(null);
                var result = compiler.ShowDialog();
                if (result.HasValue && result.Value)
                {
                    compiledRoutines = compiler.Results.CompiledAssembly;
                }
                else if (compiler.Results != null)
                {
                    var errors = "";
                    foreach (CompilerError err in compiler.Results.Errors)
                    {
                        if (!err.IsWarning)
                            errors += $"{err}\r\n";
                    }
                    MessageBox.Show(errors, "CompilerErrors");
                    LoadAssembly();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
#endif
        }

        private void InitWrapers()
        {
            SilverfishWrapper.Action.Type = compiledRoutines.GetType("HREngine.Bots.Action");
            Ai.Type = compiledRoutines.GetType("HREngine.Bots.Ai");
            Card.Type = compiledRoutines.GetType("HREngine.Bots.CardDB+Card");
            CardDB.Type = compiledRoutines.GetType("HREngine.Bots.CardDB");
            Handcard.Type = compiledRoutines.GetType("HREngine.Bots.Handmanager+Handcard");
            Hrtprozis.Type = compiledRoutines.GetType("HREngine.Bots.Hrtprozis");
            Minion.Type = compiledRoutines.GetType("HREngine.Bots.Minion");
            Playfield.Type = compiledRoutines.GetType("HREngine.Bots.Playfield");
            QuestItem.Type = compiledRoutines.GetType("HREngine.Bots.Questmanager+QuestItem");
            SecretItem.Type = compiledRoutines.GetType("HREngine.Bots.SecretItem");
            Settings.Type = compiledRoutines.GetType("HREngine.Bots.Settings");
            TestBase.Type = compiledRoutines.GetType("HREngine.Bots.TestBase");
            LoadConfigFile();
            ConstructCardList();
            CompileRoutinesWorkerCompleted();
        }

        private void MainWindowUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            ErrorLog("[Runtime Exception] " + e.Exception);
            e.Handled = true;
        }

        private string GetSourceOnlineImageFromAction(SilverfishWrapper.Action action)
        {
            string image = "";
            try
            {
                if (action.card != null)
                {
                    var hc = new Handcard(action.card);
                    var card = new Card(hc.card);
                    image = card.OnlineCardImage;
                }
                else
                {
                    var minion = new Minion(action.own);
                    var hc = new Handcard(minion.handcard);
                    var card = new Card(hc.card);
                    image = card.OnlineCardImage;
                }
            }
            catch { }
            return image;
        }

        private string GetTargetOnlineImageFromAction(SilverfishWrapper.Action action)
        {
            string image = "";
            try
            {
                if (action.target != null)
                {
                    var minion = new Minion(action.target);
                    var hc = new Handcard(minion.handcard);
                    var card = new Card(hc.card);
                    image = card.OnlineCardImage;
                }
            }
            catch { }
            return image;
        }

        public void DisplayCurrentPlayField(object pfInst)
        {
            var playfield = new Playfield(pfInst);
            var prozis = new Hrtprozis(playfield.prozis);
            OwnMinionsListBox.ItemsSource = (IEnumerable)playfield.ownMinions;
            EnemyMinionsListBox.ItemsSource = (IEnumerable)playfield.enemyMinions;
            OwnHandCardListBox.ItemsSource = (IEnumerable)playfield.owncards;
            List<Card> ownDeck = new List<Card>();
            var tdEnumerator = (IEnumerable)prozis.turnDeck;
            foreach (object pair in tdEnumerator)
            {
                Card card = new Card(new CardDB(CardDB.Instance).getCardDataFromID((cardIDEnum)pair.ReflectionCall<int>("get_Key")));
                card.count = pair.ReflectionCall<int>("get_Value");
                ownDeck.Add(card);
            }
            OwnDeckCardListBox.ItemsSource = ownDeck;
            List<InfoItem> info = new List<InfoItem>();
            var ownHero = new Minion(playfield.ownHero);
            var enemyHero = new Minion(playfield.enemyHero);
            var ownQuest = new QuestItem(playfield.ownQuest);
            var enemyQuest = new QuestItem(playfield.enemyQuest);
            info.Add(new InfoItem { Item = "水晶", Value = playfield.mana + " / " + playfield.ownMaxMana });
            info.Add(new InfoItem { Item = "我方英雄", Value = playfield.ownHeroName.ToString() + "\n[生命: " + ownHero.Hp + "+" + ownHero.armor + "] [手牌: " + playfield.owncards.ReflectionCall<int>("get_Count") + "] [奥秘数: " + playfield.ownSecretsIDList.ReflectionCall<int>("get_Count") + "]" });
            info.Add(new InfoItem { Item = "敌方英雄", Value = playfield.enemyHeroName + "\n[生命: " + enemyHero.Hp + "+" + enemyHero.armor + "] [手牌: " + playfield.enemyAnzCards + "] [奥秘数: " + playfield.enemySecretCount + "] " + (enemyHero.immune ? "[免疫]" : "") });
            info.Add(new InfoItem { Item = "我方任务", Value = ownQuest.Id + " [" + ownQuest.questProgress + "/" + ownQuest.maxProgress + "]" });
            info.Add(new InfoItem { Item = "敌方任务", Value = enemyQuest.Id + " [" + enemyQuest.questProgress + "/" + enemyQuest.maxProgress + "]" });
            if (playfield.enemyGuessDeck != "")
            {
                info.Add(new InfoItem
                {
                    Item = "猜测对手构筑",
                    Value = playfield.enemyGuessDeck + "\n预计直伤: " + prozis.enemyDirectDmg + " 预估伤害: " + (prozis.enemyDirectDmg + playfield.calEnemyTotalAngr()).ToString()
                });
            }
            GeneralInfoListBox.ItemsSource = info;
            List<ActionItem> playfieldActionItem = new List<ActionItem>();

            var playActions = playfield.playactions as IEnumerable;
            var paEnumerator = playActions.GetEnumerator();
            while (paEnumerator.MoveNext())
            {
                var action = new SilverfishWrapper.Action(paEnumerator.Current);
                playfieldActionItem.Add(new ActionItem { Action = action.printString(), Source = GetSourceOnlineImageFromAction(action), Target = GetTargetOnlineImageFromAction(action) });
            }

            PlayfieldActionListBox.ItemsSource = playfieldActionItem;

            PlayfieldScoreLabel.Content = playfield.value;
            PlayfieldSerializedTextBox.Text = PlayfieldSerializer.Instance.SerializePlayfield(playfield);
        }

        public void UpdatePlayfieldActionList(int select = 0)
        {
            PlayfieldStepComboBox.Items.Clear();
            foreach (KeyValuePair<string, object> entry in playfieldActionList)
                PlayfieldStepComboBox.Items.Add(entry.Key);
            PlayfieldStepComboBox.SelectedIndex = select;
        }
        public void UpdateBestActionList(object actions)
        {
            // 先清空 BestActionListBox 的 ItemsSource
            BestActionListBox.ItemsSource = null;

            // 清空现有的 bestActionItem 列表
            bestActionItem.Clear();

            var playActions = actions as IEnumerable;
            var paEnumerator = playActions.GetEnumerator();
            while (paEnumerator.MoveNext())
            {
                var action = new SilverfishWrapper.Action(paEnumerator.Current);
                bestActionItem.Add(new ActionItem
                {
                    Action = action.printString(),
                    Source = GetSourceOnlineImageFromAction(action),
                    Target = GetTargetOnlineImageFromAction(action)
                });
            }

            // 重新设置新的 ItemsSource
            BestActionListBox.ItemsSource = bestActionItem;

            // 更新其他相关内容
            UpdateScoreMapList();
        }

        public void UpdateScoreMapList()
        {
            ActionScoreComboBox.Items.Clear();
            ActionScoreComboBox.SelectedIndex = -1;
            foreach (KeyValuePair<float, List<ActionItem>> pair in actionScoreMap.OrderBy(key => -key.Key))
            {
                ActionScoreComboBox.Items.Add(pair.Key);
            }
            ActionScoreComboBox.SelectedIndex = 0;
        }
        public void UpdateActionViewTree(int level, int id, float score, object actionList, object pfInst)
        {
            var playfield = new Playfield(pfInst);
            int actionCount = actionList.ReflectionCall<int>("get_Count");
            if (level < 0 || actionCount != level)
            {
                ErrorLog("[Simulation] Reported action mismatch error.");
                return;
            }

            ActionItem root = null;
            if (level == 0)
            {
                actionItem = new ActionItem { Score = 0, Action = "Current Board", Board = playfield, Level = level, Decision = "DarkRed" };
                actionScoreMap.Clear();
                ActionScoreComboBox.Items.Clear();
                ActionScoreComboBox.SelectedItem = -1;
                lastHighlightedScore = -1;
            }
            else if (level == 1)
            {
                var firstAction = new SilverfishWrapper.Action(actionList.ReflectionCall<object>("get_Item", 0));
                ActionItem item = new ActionItem { Score = score, Action = firstAction.printString(), Source = GetSourceOnlineImageFromAction(firstAction), Target = GetTargetOnlineImageFromAction(firstAction), Father = actionItem, Board = playfield, Level = level, Decision = "DarkRed" };
                actionItem.subGroups.Add(item);
                if (actionScoreMap.ContainsKey(score))
                    actionScoreMap[score].Add(item);
                else
                {
                    actionScoreMap[score] = new List<ActionItem>();
                    actionScoreMap[score].Add(item);
                }
            }
            else
            {
                root = actionItem;
                for (int i = 0; i < level; i++)
                {
                    var action = new SilverfishWrapper.Action(actionList.ReflectionCall<object>("get_Item", i));
                    if (i == level - 1)
                    {
                        ActionItem item = new ActionItem { Score = score, Action = action.printString(), Source = GetSourceOnlineImageFromAction(action), Target = GetTargetOnlineImageFromAction(action), Father = root, Board = playfield, Level = level, Decision = "DarkRed" };
                        root.subGroups.Add(item);
                        if (actionScoreMap.ContainsKey(score))
                            actionScoreMap[score].Add(item);
                        else
                        {
                            actionScoreMap[score] = new List<ActionItem>();
                            actionScoreMap[score].Add(item);
                        }
                        break;
                    }
                    else
                    {
                        foreach (ActionItem item in root.subGroups)
                        {
                            if (item.Action == action.printString())
                            {
                                root = item;
                            }
                            item.Decision = "DarkRed";
                        }
                    }
                }
            }
            ActionTreeView.ItemsSource = actionItem.Items;
        }

        private void LoadConfigFile()
        {
            XmlConfigUtil util = new XmlConfigUtil(_routineXml);

            CardSearchStatusBar.Content = "设置路径中...";
            var settings = new Settings(Settings.Instance);
            settings.mainPath = util.Read("SilverfishPath");
            string SilverfishPath = util.Read("RoutinePath") + @"\Silverfish";
            try
            {
                settings.logpath = System.IO.Path.Combine(SilverfishPath, @"Test\Data\");
                settings.path = System.IO.Path.Combine(SilverfishPath, @"data\"); // 用于CardDB类构造，读取CardDefs.xml

            }
            catch { }

            util.Write(settings.mainPath, "SilverfishPath");

            CardSearchStatusBar.Content = "Silverfish 路径配置成功";
        }

        public void ConstructCardList()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += ConstructCardListWorker;
            worker.RunWorkerCompleted += ConstructCardListWorkerCompleted;

            CardSearchStatusBar.Content = "从 CardDefs.xml 加载卡牌数据中...";
            worker.RunWorkerAsync(DateTime.Now);

            RoutineSelectionButton.IsEnabled = false;
            RoutineComboBox.IsEnabled = false;
            RoutineComboBox.SelectedItem = -1;
            RoutineComboBox.Items.Clear();
            TestSelectionButton.IsEnabled = false;
            ExecuteButton.IsEnabled = false;
            ExecuteButton.Content = "加 载 中";
            ExportSelectionButton.IsEnabled = false;
        }

        public void CompileRoutinesWorkerCompleted()
        {
            RoutineSelectionButton.IsEnabled = true;
            RoutineComboBox.IsEnabled = true;
            TestSelectionButton.IsEnabled = true;
            ExportSelectionButton.IsEnabled = true;

            TestPathBox.Text = "";
            foreach (Type type in compiledRoutines.ExportedTypes)
            {
                if (type.Name != "Behavior" && type.Name.Contains("Behavior"))
                    RoutineComboBox.Items.Add(type.Name.Replace("Behavior", ""));
            }
            InfoLog("[Compiler] Successfully compiled all routines (" + compiledRoutines.ExportedTypes.Count<Type>() + ").");
            try
            {
                XmlConfigUtil util = new XmlConfigUtil(_routineXml);
                RoutineComboBox.SelectedIndex = int.Parse(util.Read("LastRoutine"));
                InfoLog("[Routine] Selected last used routine " + RoutineComboBox.Text + ".");
                string LastTestFile = util.Read("LastTestFile");
                if (!string.IsNullOrEmpty(LastTestFile))
                    TestPathBox.Text = LastTestFile;
            }
            catch
            {
                WarnLog("[Routine] Recent history not found, reset to default.");
            }
        }

        #region ConstructedCardListCallbacks
        public void ConstructCardListWorker(object sender, DoWorkEventArgs e)
        {
            cardDB = new CardDB(CardDB.Instance);
            e.Result = (DateTime.Now - (DateTime)e.Argument).TotalSeconds;
        }

        public void ConstructCardListWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CardSearchStatusBar.Content = "加载完成 (" + ((double)e.Result).ToString("0.##") + "s)";
            CardListBox.ItemsSource = (IEnumerable)cardDB.cardlist;
            allCardsList = new List<Card>();
            var enumerator = ((IEnumerable)cardDB.cardlist).GetEnumerator();
            while (enumerator.MoveNext())
            {
                allCardsList.Add(new Card(enumerator.Current));
            }
            CardListSearchBox.IsEnabled = true;
            CardListBox.ItemsSource = allCardsList;
            ExecuteButton.IsEnabled = true;
            ExecuteButton.Content = "测 试 牌 面";
        }

        #endregion

        private void CopyCardButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button self = sender as System.Windows.Controls.Button;
            if (self != null)
            {
                Card card = self.Tag as Card;
                Clipboard.SetText(card.cardIDenum.ToString());
                self.Content = "✔";
                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += CopyCardButtonWorker;
                worker.RunWorkerCompleted += CopyCardButtonWorkerCompleted;
                CardSearchStatusBar.Content = "已复制卡牌 ID";
                worker.RunWorkerAsync(self);
            }

        }

        #region CopyCardButtonCallback
        public void CopyCardButtonWorker(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
            e.Result = e.Argument;
        }

        public void CopyCardButtonWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Windows.Controls.Button self = e.Result as System.Windows.Controls.Button;
            self.Content = "📝";
        }
        #endregion

        private void CardListSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            System.Windows.Controls.TextBox self = sender as System.Windows.Controls.TextBox;
            if (self.Text.ToString().Length == 0 || self.Text.ToString() == "全部" || self.Text.ToString().ToLower() == "all")
            {
                CardListBox.ItemsSource = allCardsList;
                return;
            }
            if (searchWorker != null && searchWorker.IsBusy)
            {
                return;
            }

            searchWorker = new BackgroundWorker();
            searchWorker.DoWork += CardListSearchTextWorker;
            searchWorker.RunWorkerCompleted += CardListSearchTextWorkerCompleted;
            CardSearchStatusBar.Content = "正在检索中";
            searchWorker.RunWorkerAsync(self.Text.ToString());
        }

        #region CardListSearchTextWorker
        void CardListSearchTextWorker(object sender, DoWorkEventArgs e)
        {
            string condition = e.Argument as string;
            try
            {
                List<Card> deck = DeckHelper.Deserialize(condition);
                deck.Sort((emp1, emp2) => emp1.cost.CompareTo(emp2.cost));
                e.Result = deck;
            }
            catch
            {
                e.Result = allCardsList.FindAll(match => { return String.Concat(match.cardIDenum.ToString(), match.textCN, match.nameCN.ToString(), match.nameEN.ToString()).Contains(condition); });
            }
        }

        void CardListSearchTextWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CardListBox.ItemsSource = e.Result as List<Card>;
            CardSearchStatusBar.Content = "检索完成";
        }
        #endregion

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            XmlConfigUtil util = new XmlConfigUtil(_routineXml);
            var settings = new Settings(Settings.Instance);

            util.Write(settings.mainPath, "SilverfishPath");
            CardSearchStatusBar.Content = "Silverfish 路径配置成功";
        }

        public static void ShowOpenWithDialog(string path)
        {
            var args = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "shell32.dll");
            args += ",OpenAs_RunDLL " + path;
            Process.Start("rundll32.exe", args);
        }

        private void CheckCardButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button self = sender as System.Windows.Controls.Button;
            var settings = new Settings(Settings.Instance);
            if (self != null)
            {
                Card card = self.Tag as Card;
                string cardId = card.cardIDenum.ToString();
                List<string> allFiles = new DirectoryInfo(System.IO.Path.Combine(settings.mainPath, @"cards\")).EnumerateFiles("Sim_" + cardId + ".cs", SearchOption.AllDirectories).Select(d => d.FullName).ToList();
                if (allFiles.Count == 0)
                {
                    CardSearchStatusBar.Content = cardId + " 未找到相关 Sim 文件！";
                    self.ToolTip = "找不到文件";
                    self.Content = "❓";
                    self.IsEnabled = false;
                }
                else if (allFiles.Count == 1 && self.Content.ToString().CompareTo("📂") == 0)
                {
                    ShowOpenWithDialog(allFiles.First());
                    CardSearchStatusBar.Content = cardId + " 已打开！";
                }
                else if (allFiles.Count == 1)
                {
                    CardSearchStatusBar.Content = cardId + " 已找到相关 Sim 文件！";
                    self.ToolTip = "打开 Sim 文件";
                    self.Content = "📂";
                }
                else
                {
                    CardSearchStatusBar.Content = cardId + " 找到过多匹配的 Sim 文件！";
                    self.ToolTip = "文件匹配过多";
                    self.Content = "❓";
                    self.IsEnabled = false;
                }
            }
        }

        private void RoutineComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                #region Update Mulligan Selection
                if (RoutineComboBox.Items.Count == 0)
                    return;
                var settings = new Settings(Settings.Instance);
                string path = System.IO.Path.Combine(settings.mainPath, @"Routines\DefaultRoutine\Silverfish\behavior\" + RoutineComboBox.SelectedItem.ToString() + @"\_mulligan.txt");
                MulliganContentTextBlock.Document.Blocks.Clear();
                String line;
                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    StreamReader sr = new StreamReader(path, Encoding.GetEncoding("GB2312"));

                    //Read the first line of text
                    line = sr.ReadLine();
                    //Continue to read until you reach end of file
                    while (line != null)
                    {
                        //write the line to console window
                        MulliganContentTextBlock.Document.Blocks.Add(new Paragraph(new Run(line)));
                        //Read the next line
                        line = sr.ReadLine();
                    }
                    //close the file
                    sr.Close();
                    MulliganContentScrollViewer.ScrollToBottom();
                    SuccessLog("[Mulligan] Successfully read mulligan file.");
                }
                catch (Exception exception)
                {
                    ErrorLog("[Mulligan] Exception occurred when reading mulligan file: " + exception.Message);
                }
                #endregion
                XmlConfigUtil util = new XmlConfigUtil(_routineXml);
                util.Write(RoutineComboBox.SelectedIndex.ToString(), "LastRoutine");
            }
            catch { }
        }

        private void TestSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog()
            {
                Filter = "Playfield Log File|*.txt",
                DereferenceLinks = false
            };
            var result = openFileDialog.ShowDialog();
            if (result == true)
            {
                TestPathBox.Text = openFileDialog.FileName;
                XmlConfigUtil util = new XmlConfigUtil(_routineXml);
                util.Write(TestPathBox.Text, "LastTestFile");
            }
            else
            {
                TestPathBox.Text = "";
            }
        }

        public void ErrorLog(string content)
        {
            AddLog(content, Brushes.DarkRed);
        }

        public void InfoLog(string content)
        {
            AddLog(content, Brushes.Black);
        }

        public void SuccessLog(string content)
        {
            AddLog(content, Brushes.DarkGreen);
        }

        public void WarnLog(string content)
        {
            AddLog(content, Brushes.DarkGoldenrod);
        }

        private void AddLog(string content, Brush brush)
        {
            Run run = new Run(content + "\r\n");
            run.Foreground = brush;

            // 将 Run 对象添加到 RichTextBox 的 Paragraph 中
            Paragraph paragraph = LogRichTextBox.Document.Blocks.FirstBlock as Paragraph;
            if (paragraph != null)
            {
                paragraph.Inlines.Add(run);
            }

            // 滚动到最底部
            LogScrollViewer.ScrollToEnd();
        }

        private void RoutineSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            var compiler = new CompilerWindow(null);

            // 获取当前窗口的位置信息
            var currentWindow = Window.GetWindow(this);

            // 计算当前窗口的中心点
            double centerX = currentWindow.Left + (currentWindow.Width - compiler.Width) / 2;
            double centerY = currentWindow.Top + (currentWindow.Height - compiler.Height) / 2;

            // 设置 CompilerWindow 的启动位置为手动并应用计算的中心点
            compiler.WindowStartupLocation = WindowStartupLocation.Manual;
            compiler.Left = centerX;
            compiler.Top = centerY;

            var result = compiler.ShowDialog();
            if (result.HasValue && result.Value)
            {
                compiledRoutines = compiler.Results.CompiledAssembly;
                InitWrapers();
            }
            else if (compiler.Results != null)
            {
                var errors = "";
                foreach (CompilerError err in compiler.Results.Errors)
                {
                    if (!err.IsWarning)
                        errors += $"{err}\r\n";
                }
                MessageBox.Show(errors, "CompilerErrors");
            }
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(TestPathBox.Text) || RoutineComboBox.SelectedIndex == -1)
            {
                ErrorLog("[Start] Setup is not completed, aborting.");
                return;
            }
            InfoLog("[Start] Setting up AI test...");
            bestActionItem.Clear();
            InfoLog("[Compiler] Now starting to test file...");
            try
            {
                var type = compiledRoutines.GetType("HREngine.Bots.Behavior" + RoutineComboBox.SelectedItem.ToString());
                AiTestClass test = new AiTestClass(Activator.CreateInstance(compiledRoutines.GetType("HREngine.Bots.TestBase")));
                test.Test(TestPathBox.Text, Activator.CreateInstance(type));
                SuccessLog("[Start] AI test complete!");
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }

        private void DeleteLogButton_Click(object sender, RoutedEventArgs e)
        {
            // 清空 RichTextBox 中的所有内容
            Paragraph paragraph = LogRichTextBox.Document.Blocks.FirstBlock as Paragraph;
            if (paragraph != null)
            {
                paragraph.Inlines.Clear();
            }

            //并清空日志
            var settings = new Settings(Settings.Instance);
            string path = Path.Combine(settings.logpath, settings.logfile);
            // 清空日志文件
            if (File.Exists(path))
            {
                // 清空文件内容
                File.WriteAllText(path, string.Empty);
            }
        }

        private void CardNameLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label label = sender as Label;
            DragDrop.DoDragDrop(label, label.Tag, DragDropEffects.Move);
        }

        private string StringFromRichTextBox()
        {
            TextRange textRange = new TextRange(
                // TextPointer to the start of content in the RichTextBox.
                MulliganContentTextBlock.Document.ContentStart,
                // TextPointer to the end of content in the RichTextBox.
                MulliganContentTextBlock.Document.ContentEnd
            );

            // The Text property on a TextRange object returns a string
            // representing the plain text content of the TextRange.
            return textRange.Text;
        }

        private void AddMulliganButton_Click(object sender, RoutedEventArgs e)
        {
            MulliganHandCard.Text = MulliganHandCard.Text.Trim();
            MulliganCard.Text = MulliganCard.Text.Trim();
            if (!MulliganCard.Text.Contains("_"))
            {
                MulliganCard.Text = "";
                ErrorLog("[Mulligan] Please select correct card ID!");
                return;
            }
            if (MulliganHandCard.Text.StartsWith("/"))
            {
                MulliganHandCard.Text = MulliganHandCard.Text.Substring(1);
            }
            if (!MulliganHandCard.Text.EndsWith("/"))
            {
                MulliganHandCard.Text = MulliganHandCard.Text + "/";
            }
            var code = MulliganCard.Text + ";" + ((ComboBoxItem)MulliganOwnHero.SelectedItem).Tag + ";" + ((ComboBoxItem)MulliganEnemyHero.SelectedItem).Tag + ";" +
                    ((ComboBoxItem)MulliganStrategy.SelectedItem).Tag + ";" + MulliganHandCard.Text + ((ComboBoxItem)MulliganOrder.SelectedItem).Tag;
            MulliganContentTextBlock.Document.Blocks.Add(new Paragraph(new Run(code)));
            MulliganContentScrollViewer.ScrollToBottom();
        }

        private void SaveMulliganButton_Click(object sender, RoutedEventArgs e)
        {
            #region Update Mulligan Selection
            var settings = new Settings(Settings.Instance);
            string path = System.IO.Path.Combine(settings.mainPath, @"behavior\" + RoutineComboBox.SelectedItem.ToString() + @"\_mulligan.txt");
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(path);
                sw.Write(StringFromRichTextBox());
                //Close the file
                sw.Close();
                MulliganContentScrollViewer.ScrollToBottom();
                SuccessLog("[Mulligan] Successfully saved mulligan to file.");
            }
            catch (Exception exception)
            {
                ErrorLog("[Mulligan] Exception occurred when trying to save mulligan to file: " + exception.Message);
            }
            #endregion
        }

        private void RemoveMulliganButton_Click(object sender, RoutedEventArgs e)
        {
            if (MulliganContentTextBlock.Document.Blocks.Count != 0)
            {
                MulliganContentTextBlock.Document.Blocks.Remove(MulliganContentTextBlock.Document.Blocks.LastBlock);
                MulliganContentScrollViewer.ScrollToBottom();
                InfoLog("[Mulligan] Deleted last record.");
            }
            else
            {
                WarnLog("[Mulligan] No more record to delete!");
            }
        }

        static TextPointer last = null;
        private void MulliganContentTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                TextPointer start = MulliganContentTextBlock.CaretPosition;  // this is the variable we will advance to the left until a non-letter character is found
                TextPointer end = start;    // this is the variable we will advance to the right until a non-letter character is found
                if (start.Equals(last))
                    return;
                last = start;
                string stringBeforeCaret = start.GetTextInRun(LogicalDirection.Backward);   // extract the text in the current run from the caret to the left
                string stringAfterCaret = start.GetTextInRun(LogicalDirection.Forward);     // extract the text in the current run from the caret to the left

                Int32 countToMoveLeft = 0;  // we record how many positions we move to the left until a non-letter character is found
                Int32 countToMoveRight = 0; // we record how many positions we move to the right until a non-letter character is found

                for (Int32 i = stringBeforeCaret.Length - 1; i >= 0; --i)
                {
                    // if the character at the location CaretPosition-LeftOffset is a letter, we move more to the left
                    if (Char.IsLetter(stringBeforeCaret[i]) || Char.IsDigit(stringBeforeCaret[i]) || stringBeforeCaret[i].Equals('_'))
                        ++countToMoveLeft;
                    else break; // otherwise we have found the beginning of the word
                }


                for (Int32 i = 0; i < stringAfterCaret.Length; ++i)
                {
                    // if the character at the location CaretPosition+RightOffset is a letter, we move more to the right
                    if (Char.IsLetter(stringAfterCaret[i]) || Char.IsDigit(stringAfterCaret[i]) || stringAfterCaret[i].Equals('_'))
                        ++countToMoveRight;
                    else break; // otherwise we have found the end of the word
                }



                start = start.GetPositionAtOffset(-countToMoveLeft);    // modify the start pointer by the offset we have calculated
                end = end.GetPositionAtOffset(countToMoveRight);        // modify the end pointer by the offset we have calculated


                // extract the text between those two pointers
                TextRange r = new TextRange(start, end);
                String text = r.Text;
                // WarnLog(text);
                try
                {
                    Card card = new Card(cardDB.getCardDataFromID((cardIDEnum)Enum.Parse(typeof(cardIDEnum), text)));

                    BitmapImage bitmap = new BitmapImage(new Uri(card.OnlineCardImage, UriKind.Absolute));
                    ToolTipCardPicture.Source = bitmap;
                }
                catch
                {
                    ToolTipCardPicture.Source = null;
                }
            }
            catch (Exception exception) { ErrorLog("[Mulligan] Card display: " + exception.Message); }
        }

        private void PlayfieldStepComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object pfInst = null;
            if (PlayfieldStepComboBox.SelectedItem == null || isExporting)
            {
                return;
            }
            playfieldActionList.TryGetValue(PlayfieldStepComboBox.SelectedItem.ToString(), out pfInst);
            if (pfInst != null)
            {
                if (pfInst is Playfield playfield)
                    DisplayCurrentPlayField(playfield.Inst);
                else
                    DisplayCurrentPlayField(pfInst);
                SuccessLog("[Playfield] Now choose to display " + PlayfieldStepComboBox.SelectedItem.ToString() + ".");
            }
            else
            {
                ErrorLog("[Playfield] Failed to display " + PlayfieldStepComboBox.SelectedItem.ToString() + ".");
            }

        }

        private void ActionScoreComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (lastHighlightedScore != -1)
                {
                    foreach (ActionItem action in actionScoreMap[lastHighlightedScore])
                    {
                        ActionItem item = action;
                        do
                        {
                            item.Decision = "DarkRed";
                            item = item.Father;
                        } while (item != null);
                    }
                }
                float score = float.Parse(ActionScoreComboBox.SelectedItem.ToString());
                foreach (ActionItem action in actionScoreMap[score])
                {
                    ActionItem item = action;
                    do
                    {
                        item.Decision = "DarkGreen";
                        item = item.Father;
                    } while (item != null);
                }
                lastHighlightedScore = score;
                ActionTreeView.ItemsSource = actionItem.Items;
            }
            catch { }
        }

        private void VisualizePlayfieldButton_Click(object sender, RoutedEventArgs e)
        {
            ActionItem actionItem = (sender as System.Windows.Controls.Button).Tag as ActionItem;
            playfieldActionList.Clear();
            ActionItem item = actionItem;
            do
            {
                playfieldActionList.Add((item.Level == 0) ? "回合开始" : "第" + item.Level.ToString() + "步", item.Board);
                item = item.Father;
            } while (item != null);
            PlayfieldStepComboBox.SelectedIndex = -1;
            UpdatePlayfieldActionList();
            ProgramTabControl.SelectedItem = PlayfieldVisualizerTab;
        }

        private void ExportSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog diag = new System.Windows.Forms.FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = diag.SelectedPath;
                if (!string.IsNullOrEmpty(folder))
                {
                    ExportPathBox.Text = folder;
                    GenerateButton.IsEnabled = true;
                }
            }
        }

        public static void DoEvents()
        {
            Application.Current.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Background,
                                                  new System.Action(delegate { }));
        }

        public void ExportPlayfield(string path, ActionItem item)
        {
            foreach (ActionItem each in item.subGroups)
            {
                DoEvents();
                ExportPlayfield(path, each);
                DoEvents();
            }
            Playfield playfield = item.Board;
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(PlayfieldSerializer.Instance.SerializePlayfield(playfield) + "," + item.Score.ToString());
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(PlayfieldSerializer.Instance.SerializePlayfield(playfield) + "," + item.Score.ToString());
                }
            }
            DoEvents();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ExportPathBox.Text))
            {
                string[] sources = new DirectoryInfo(ExportPathBox.Text).EnumerateFiles("*.txt", SearchOption.AllDirectories).Select(d => d.FullName).ToArray();
                InfoLog("[Exporter] Now starting to export files...");
                isExporting = true;
                int index = 0;
                AiTestClass test = new AiTestClass(compiledRoutines.GetType("HREngine.Bots.TestBase"));
                var type = compiledRoutines.GetType("HREngine.Bots.Behavior" + RoutineComboBox.SelectedItem.ToString());
                foreach (string file in sources)
                {
                    DoEvents();
                    test.Test(file, Activator.CreateInstance(type));
                    DoEvents();
                    ExportPlayfield(@"SerializedResult.txt", actionItem);
                    InfoLog("[Exporter] " + index.ToString() + " / " + sources.Length.ToString());
                    index++;
                }
                isExporting = false;
                SuccessLog("[Exporter] Export complete!");
            }
            else
            {
                ErrorLog("[Exporter] Path undefined.");
            }
        }

        private void ExportCardButton_Click(object sender, RoutedEventArgs e)
        {
            string path = @"SerializedCard.txt";
            ExportCardButton.IsEnabled = false;
            var enumerator = ((IEnumerable)cardDB.cardlist).GetEnumerator();
            while (enumerator.MoveNext())
            {
                var card = new Card(enumerator.Current);
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(Regex.Replace(card.textCN, @"\t|\n|\r", ""));
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(Regex.Replace(card.textCN, @"\t|\n|\r", ""));
                    }
                }
                DoEvents();
            }
            ExportCardButton.IsEnabled = true;

        }

        private void MainWindowLayout_Loaded(object sender, RoutedEventArgs e)
        {
            ExecuteButton.IsEnabled = false;
            ExecuteButton.Content = "加 载 中";
            DataContext = this;
            Application.Current.DispatcherUnhandledException += MainWindowUnhandledException;
            InitWrapers();
        }
    }

    public class AiTestClass : TestBase
    {
        public AiTestClass(object baseInst) : base(baseInst)
        {

        }
        public void Test(string testFilePath, object behavior)
        {
            var settings = new Settings(Settings.Instance);
            settings.test = true;
            var data = File.ReadAllText(testFilePath);
            InitSetting();

            Ai ai = new Ai(Ai.Instance);
            ai.botBase = behavior;  //根据卡组选择合适的策略

            ai.autoTester(true, data, 0);// 0：全做 1:只斩杀 2：正常
        }
    }
}
