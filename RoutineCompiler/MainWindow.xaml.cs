using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.ComponentModel;

namespace RoutineCompiler
{
    
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public string mainPath = "";
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            #region 加载 XML 配置文件
            XmlConfigUtil util = new XmlConfigUtil("routine.xml");

            mainPath = util.Read("SilverfishPath");

            bool retry = false;
            while (string.IsNullOrEmpty(mainPath) || !Directory.Exists(mainPath))
            {
                SettingsPopup popup = new SettingsPopup(mainPath, retry ? "文件夹核验错误，请重新选择！" : "请选择 Silverfish 文件夹路径！");
                popup.Left = this.Left + (this.Width - popup.Width) / 2;
                popup.Top = this.Top + (this.Height - popup.Height) / 2;
                var result = popup.ShowDialog();
                if (!result ?? true)
                {
                    Environment.Exit(0);
                }
                mainPath = popup.silverfishPath;
                retry = true;
            }

            util.Write(mainPath, "SilverfishPath");


            #endregion
        }


        private static void ExtractEmbeddedAssembly(string manifestResourceName, string path)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(new AssemblyName(Assembly.GetExecutingAssembly().FullName).Name + ".lib." + manifestResourceName))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                using (FileStream fstream = new FileStream(path, FileMode.Create))
                {
                    fstream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        /// <summary>
        /// 错误日志打印
        /// </summary>
        /// <param name="content"></param>
        public void ErrorLog(string content)
        {
            AddLog(content, Brushes.DarkRed);
        }

        /// <summary>
        /// 正常日志打印
        /// </summary>
        /// <param name="content"></param>
        public void InfoLog(string content)
        {
            AddLog(content, Brushes.Black);
        }

        /// <summary>
        /// 成功日志打印
        /// </summary>
        /// <param name="content"></param>
        public void SuccessLog(string content)
        {
            AddLog(content, Brushes.DarkGreen);
        }

        /// <summary>
        /// 警告日志打印
        /// </summary>
        /// <param name="content"></param>
        public void WarnLog(string content)
        {
            AddLog(content, Brushes.DarkGoldenrod);
        }

        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="content"></param>
        /// <param name="brush"></param>
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
            LogRichTextBox.ScrollToEnd();
        }

        private void LaunchButton_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("RoutineHelper.exe") && File.Exists("Silverfish.dll"))
            {
                SuccessLog("[Launch] Preparing to launch the executable.");

                ProcessStartInfo pInfo = new ProcessStartInfo("RoutineHelper.exe");
                pInfo.WorkingDirectory = @".";
                Process p = Process.Start(pInfo);
                Application.Current.Shutdown();
            }
            else if (!File.Exists("Silverfish.dll") && File.Exists("RoutineHelper.exe"))
            {
                ErrorLog("[Launch] Failed to find Silverfish.dll, run compile first.");
            }
            else
                ErrorLog("[Launch] Failed to find the executable.");
        }

        private void RecompileButton_Click(object sender, RoutedEventArgs e)
        {
            BackgroundWorker routineWorker = new BackgroundWorker();
            routineWorker.DoWork += CompileRoutinesWorker;
            routineWorker.RunWorkerCompleted += CompileRoutinesWorkerCompleted;
            InfoLog("[Compiler] Now starting to compile silverfish...");
            RecompileButton.IsEnabled = false;
            LaunchButton.IsEnabled = false;
            routineWorker.RunWorkerAsync();
        }

        #region CompileRoutinesCallbacks
        public void CompileRoutinesWorker(object sender, DoWorkEventArgs e)
        {
            string FilePath = e.Argument as string;

            try
            {
                using (CSharpCodeProvider csharpCodeProvider = new CSharpCodeProvider())
                {
                    CompilerParameters compilerParameters = new CompilerParameters
                    {
                        GenerateExecutable = false,
                        GenerateInMemory = false,
                        CompilerOptions = "-define:APPLICATION_MODE",
                        OutputAssembly = "Silverfish.dll"
                };
                    List<string> exceptionList = new List<string> {
                        "log4net.dll",
                        "Hearthbuddy.exe",
                        "IronPython.dll",
                        "Microsoft.Scripting.dll",
                        "PresentationCore.dll",
                        "PresentationFramework.dll",
                        "WindowsBase.dll",
                        "GreyMagic.dll",
                        "DefaultBot.dll"
                    };
                    string path = System.IO.Path.GetTempPath();
                    foreach (AssemblyName name in System.Reflection.Assembly.GetEntryAssembly().GetReferencedAssemblies())
                    {
                        if (name.Name.StartsWith("Presentation"))
                            continue;
                        compilerParameters.ReferencedAssemblies.Add(name.Name + ".dll");
                    }
                    foreach (string name in exceptionList)
                    {
                        ExtractEmbeddedAssembly(name, System.IO.Path.Combine(path, name));
                        compilerParameters.ReferencedAssemblies.Add(System.IO.Path.Combine(path, name));
                    }
                    compilerParameters.ReferencedAssemblies.Add("RoutineHelper.exe");
                    compilerParameters.ReferencedAssemblies.Add(typeof(MainWindow).Assembly.Location);
                    string[] sources = new DirectoryInfo(System.IO.Path.Combine(mainPath, @"../")).EnumerateFiles("*.cs", SearchOption.AllDirectories).Select(d => d.FullName).ToArray();
                    CompilerResults compilerResults = csharpCodeProvider.CompileAssemblyFromFile(compilerParameters, sources);
                    e.Result = compilerResults;
                    return;
                }
            }
            catch (Exception exception)
            {
                // ErrorLog("[Compiler] " + exception.Message);
            }
            e.Result = null;
        }

        public void CompileRoutinesWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result == null)
            {
                ErrorLog("[Compiler] An unknown exception occurred during compilation.");
                return;
            }
            CompilerResults compilerResults = e.Result as CompilerResults;
            bool flag = compilerResults.Errors.Count > 0;
            if (flag)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (object obj in compilerResults.Errors)
                {
                    CompilerError compilerError = (CompilerError)obj;
                    object[] args = new object[]
                    {
                                "Line number ",
                                compilerError.Line,
                                ", Error Number: ",
                                compilerError.ErrorNumber,
                                ", '",
                                compilerError.ErrorText,
                                ", '",
                                compilerError.FileName,
                                "'"
                    };
                    stringBuilder.AppendFormat(string.Concat(args), Array.Empty<object>());
                    stringBuilder.AppendLine();
                }
                ErrorLog("[Compiler] An exception occurred during compilation: " + stringBuilder.ToString());
                RecompileButton.IsEnabled = true;
                LaunchButton.IsEnabled = true;
                return;
            }
            
            //RoutineComboBox.SelectedItem = 1;
            SuccessLog("[Compiler] Successfully compiled silverfish.");
            RecompileButton.IsEnabled = true;
            LaunchButton.IsEnabled = true;

        }

        #endregion

        private void ReconfigureButton_Click(object sender, RoutedEventArgs e)
        {
            #region 加载 XML 配置文件
            XmlConfigUtil util = new XmlConfigUtil("routine.xml");

            mainPath = util.Read("SilverfishPath");

            bool retry = false;
            do
            {
                SettingsPopup popup = new SettingsPopup(mainPath, retry ? "文件夹核验错误，请重新选择！" : "请选择 Silverfish 文件夹路径！");
                popup.Left = this.Left + (this.Width - popup.Width) / 2;
                popup.Top = this.Top + (this.Height - popup.Height) / 2;
                popup.ShowDialog();
                mainPath = popup.silverfishPath;
                retry = true;
            }
            while (string.IsNullOrEmpty(mainPath) || !Directory.Exists(mainPath));

            util.Write(mainPath, "SilverfishPath");


            #endregion
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
}
