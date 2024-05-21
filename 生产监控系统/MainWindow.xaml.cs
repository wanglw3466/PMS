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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using 生产监控系统.Command;
using 生产监控系统.UserControls;
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
        /// <summary>
        /// 把事件绑定放在ViewModel中不起作用，不知道为啥？只能移动到MainWindow
        /// </summary>
        //定义事件
        public void showShopDetail()
        {
            WorkShopDetailUC workShopDetailUC = new WorkShopDetailUC();
            mainViewModel.MonitorUC = workShopDetailUC;

            //1.定义动画 动画效果 自下而上 位移 移动时间
            ThicknessAnimation thicknessAnimation = new ThicknessAnimation(new Thickness(0, 150, 0, -150), new Thickness(0, 0, 0, 0), new TimeSpan(0,0,0,0,400));
            //2.定义透明度
            DoubleAnimation doubleAnimation = new DoubleAnimation(0,1,new TimeSpan(0,0,0,0,400));

            //3.把动画，透明度加载到storyboard
            Storyboard.SetTarget(thicknessAnimation,workShopDetailUC);
            Storyboard.SetTarget(doubleAnimation, workShopDetailUC);

            Storyboard.SetTargetProperty(thicknessAnimation,new PropertyPath("Margin"));
            Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("Opacity"));

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(thicknessAnimation);
            storyboard.Children.Add(doubleAnimation);

            //4.开始动画
            storyboard.Begin();
        }
        //绑定事件
        public ICommand ShowCommand
        {
            get
            {
                return new DetailCommand(showShopDetail);
            }
        }

    }
}
