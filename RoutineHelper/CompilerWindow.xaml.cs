using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;
using Path = System.IO.Path;

namespace RoutineHelper
{
    /// <summary>
    /// SettingsPopup.xaml 的交互逻辑
    /// </summary>
    public partial class CompilerWindow : Window
    {
        public string RoutinePath;

        public CompilerResults Results = null;

        private readonly string _routineXml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Settings\Default\routine.xml");

        public CompilerWindow(string hint)
        {
            InitializeComponent();
            var util = new XmlConfigUtil(_routineXml);
            var path =  util.Read("RoutinePath");
            RoutinePath = path;
            SilverfishPathTextBox.Text = path;
            PathGroupBox.Header = hint;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            ((System.Windows.Controls.Button)sender).Content = "编译中...";
            ((System.Windows.Controls.Button)sender).IsEnabled = false;
            var result = await Task.Run(CompileRoutinesWorker);
            Results = result;
            if (!result.Errors.HasErrors)
            {
                DialogResult = true;
            }
            ((System.Windows.Controls.Button)sender).Content = "编译";
            ((System.Windows.Controls.Button)sender).IsEnabled = true;
            //写入配置
            var util = new XmlConfigUtil(_routineXml);
            util.Write(RoutinePath, "RoutinePath");
            Close();
        }

        public CompilerResults CompileRoutinesWorker()
        {
            var assemblyPath = new List<string>();
            foreach (var name in System.Reflection.Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                assemblyPath.Add(name.ToString());
            }
            try
            {
                using (var csharpCodeProvider = new CSharpCodeProvider())
                {
                    var compilerParameters = new CompilerParameters
                    {
                        GenerateExecutable = false,
                        GenerateInMemory = true,
                        CompilerOptions = "-define:APPLICATION_MODE",
                        OutputAssembly = Path.Combine("CompiledAssemblies", "Silverfish.dll")
                    };
                    var exceptionList = new List<string> {
                        "PresentationFramework",
                        "WindowsBase",
                        "PresentationCore"
                    };
                    var refList = new List<string>
                    {
                        "GreyMagic.dll",
                        "log4net.dll",
                        "IronPython.dll",
                        "IronPython.Modules.dll",
                        "Microsoft.Scripting.dll",
                        "Microsoft.Scripting.Metadata.dll",
                        "Hearthbuddy.exe",
                    };
                    foreach (var name in System.Reflection.Assembly.GetEntryAssembly().GetReferencedAssemblies())
                    {
                        if (exceptionList.Contains(name.Name))
                        {
                            var path = Assembly.Load(name).Location;
                            if (!compilerParameters.ReferencedAssemblies.Contains(path))
                                compilerParameters.ReferencedAssemblies.Add(path);
                        }
                        else
                        {
                            if (!compilerParameters.ReferencedAssemblies.Contains(name.Name + ".dll"))
                                compilerParameters.ReferencedAssemblies.Add(name.Name + ".dll");
                        }
                    }
                    foreach (var name in refList)
                    {
                        if (!compilerParameters.ReferencedAssemblies.Contains(name))
                            compilerParameters.ReferencedAssemblies.Add(name);
                    }
                    compilerParameters.ReferencedAssemblies.Add("RoutineHelper.exe");
                    var sources = new DirectoryInfo(RoutinePath).EnumerateFiles("*.cs", SearchOption.AllDirectories).Select(d => d.FullName).ToArray();

                    var compilerResults = csharpCodeProvider.CompileAssemblyFromFile(compilerParameters, sources);
                    return compilerResults;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "CompilerErrors");
            }
            return null;
        }

        private void SelectSilverfishPathButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = diag.SelectedPath;
                if (!string.IsNullOrEmpty(folder))
                {
                    RoutinePath = folder;
                    SilverfishPathTextBox.Text = folder;
                }
            }
        }
    }
}
