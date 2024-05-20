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
using System.Windows.Navigation;
using System.Windows.Shapes;
using 生产监控系统.ViewModels;

namespace 生产监控系统
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //赋值主程序数据上下文；
        private MainVeiwModel mainViewModel;
        public MainWindow()
        {
            InitializeComponent();
            mainViewModel = new MainVeiwModel();
            this.DataContext = mainViewModel;
        }
    }
}
