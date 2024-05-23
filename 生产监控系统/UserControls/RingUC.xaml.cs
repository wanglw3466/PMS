using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace 生产监控系统.UserControls
{
    /// <summary>
    /// RingUC.xaml 的交互逻辑
    /// </summary>
    public partial class RingUC : UserControl
    {
        public RingUC()
        {
            InitializeComponent();
            //2.定义大小变化后，重绘
            SizeChanged += OnSizeChanged;

        }
        //3.生成绘图方法
        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            DrawRing();
        }
        //4.绘图方法；
        private void DrawRing()
        {
             //1.获取渲染器长 宽最小值，设置Grid 值（这个图就画在这个Grid）
           LayoutGrid.Width=Math.Min(RenderSize.Width,RenderSize.Height) ;
          // LayoutGrid.Height=Math.Min(RenderSize.Width,RenderSize.Height);

            //2. 定义半径 radius;
            double radius = LayoutGrid.Width / 2;
            //3. 定义圆点（针对半径的偏移量)
            double x = radius+(radius-3)*Math.Cos((Percent%100*3.6-90)*Math.PI/180);
            double y = radius+(radius-3)*Math.Sin((Percent%100*3.6-90)*Math.PI/180);
            //4. 定义轨迹数据；
            int is50 = Percent >= 50 ? 1 : 0;
            //M 移动  A 画弧半径 {radius-3} {radius-3} |  移动路径 0 {is50} 1 {x} {y}
            string pathStr = $"M{radius+0.03} 3A{radius-3} {radius-3} 0 {is50} 1 {x} {y}";

            //5.几何图形对象 定义绘图
            var conventer= TypeDescriptor.GetConverter(typeof(Geometry));
            //6.开始绘图；
            Path.Data = (Geometry)conventer.ConvertFrom(pathStr);

        }

        //1.定义一个Percent 依赖属性
        public double Percent
        {
            get { return (double)GetValue(PercentProperty); }
            set { SetValue(PercentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Percent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PercentProperty =
            DependencyProperty.Register("Percent", typeof(double), typeof(RingUC));


    }
}
