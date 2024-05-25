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
            ThicknessAnimation thicknessAnimation = new ThicknessAnimation(new Thickness(0, 150, 0, -150), new Thickness(0, 0, 0, 0), new TimeSpan(0, 0, 0, 0, 400));
            //2.定义透明度
            DoubleAnimation doubleAnimation = new DoubleAnimation(0, 1, new TimeSpan(0, 0, 0, 0, 400));

            //3.把动画，透明度加载到storyboard
            Storyboard.SetTarget(thicknessAnimation, workShopDetailUC);
            Storyboard.SetTarget(doubleAnimation, workShopDetailUC);

            Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath("Margin"));
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
                return new BtnCommand(showShopDetail);
            }
        }
        //返回功能；
        public ICommand ReturnCommand
        {
            get
            {
                return new BtnCommand(returnFn);
            }

        }
        private void returnFn()
        {
            MonitorUC monitorUC=new MonitorUC();
            mainViewModel.MonitorUC = monitorUC;    
        }

        public ICommand TrendCommand
        {
            get
            {

                return new BtnCommand(showTrend);
            }
        }
        //定义显示设备趋势图功能 
        public void showTrend()
        {
             WorkShopDetailUC workShopDetailUC=(WorkShopDetailUC)mainViewModel.MonitorUC;
             workShopDetailUC.detail.Visibility= Visibility.Visible;    
            //定义动画效果 
            //1.定义位移
            ThicknessAnimation thicknessAnimation=new ThicknessAnimation(new Thickness(0,50,0,-50),new Thickness(0,0,0,0),new TimeSpan(0,0,0,0,1000));
            //2.定义透明度
            DoubleAnimation doubleAnimation = new DoubleAnimation(0, 1, new TimeSpan(0, 0, 0, 0, 1000));

            //3.把透明度和渐变加到 Border组件
            Storyboard.SetTarget(thicknessAnimation, workShopDetailUC.detailCotent);
            Storyboard.SetTarget(doubleAnimation,workShopDetailUC.detailCotent);

            Storyboard.SetTargetProperty( thicknessAnimation, new PropertyPath("Margin"));
            Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("Opacity"));
            
            //4.定义Storyboard
            Storyboard storyboard=new Storyboard();
            storyboard.Children.Add(thicknessAnimation);
            storyboard.Children.Add(doubleAnimation);

            //插入一个，只有当动画效果完成后才能关闭；这个是自动关闭了，感觉不是我想要的。我手工关闭即可；
            //storyboard.Completed +=(se,ev)=>{
            //    workShopDetailUC.detail.Visibility = Visibility.Collapsed;
            //};

            //5.开始动画
            storyboard.Begin();

        }
 

        //关闭机器趋势图 
        public ICommand CloseTrendCommand { get {
            return new BtnCommand(CloseTrend);
            } }

        public void CloseTrend()
        {
            WorkShopDetailUC workShopDetailUC=(WorkShopDetailUC)mainViewModel.MonitorUC;
            workShopDetailUC.detail.Visibility = Visibility.Collapsed;
        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void default_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Normal;
        }

 

        private void close_Click(object sender, RoutedEventArgs e)
        {
            //this.close() 仅关闭窗口
            Environment.Exit(0); //退出程序；
        }
    }
}