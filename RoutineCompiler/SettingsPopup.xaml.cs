using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RoutineCompiler
{
    /// <summary>
    /// SettingsPopup.xaml 的交互逻辑
    /// </summary>
    public partial class SettingsPopup : Window
    {
        public string silverfishPath;
        public SettingsPopup(string SilverfishPath, string Hint)
        {
            InitializeComponent();
            silverfishPath = SilverfishPath;
            SilverfishPathTextBox.Text = SilverfishPath;
            PathGroupBox.Header = Hint;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }


        private void SelectSilverfishPathButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = diag.SelectedPath;
                if (!string.IsNullOrEmpty(folder))
                {
                    silverfishPath = folder;
                    SilverfishPathTextBox.Text = folder;
                }
            }
        }
    }
}
