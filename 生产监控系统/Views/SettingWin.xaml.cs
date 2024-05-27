using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace 生产监控系统.Views
{
    /// <summary>
    /// SettingWin.xaml 的交互逻辑
    /// </summary>
    public partial class SettingWin : Window
    {
        public SettingWin()
        {
            InitializeComponent();
        }

        private void data_Click(object sender, RoutedEventArgs e)
        {

            //程序集 授权 路径
            string tag = "";
            var btn = sender as RadioButton;
            if (btn != null)
            {
                tag = btn.Tag.ToString();
            }
            //# 代表程序片断
            frame.Navigate(new Uri("pack://application:,,,/生产监控系统;component/Views/SettingPage.xaml#" + tag, UriKind.RelativeOrAbsolute));

        }
    }
}
