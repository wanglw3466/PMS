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
using 生产监控系统.Models;

namespace 生产监控系统.UserControls
{
    /// <summary>
    /// RaderUC.xaml 的交互逻辑
    /// Monitor（自定义控件）里面再套Rader(自定义控件）；
    /// </summary>
    public partial class RaderUC : UserControl
    {
        public RaderUC()
        {
            InitializeComponent();

            //Alt+Enter 生成新的方法
            //当窗体变化时，重新画图
            SizeChanged += OnSizeChanged;

        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            Drag();
        }

        //数据源绑定 定义依赖属性
        public List<RaderModel> ItemSource
        {
            get { return (List<RaderModel>)GetValue(ItemSourceProperty); }
            set { SetValue(ItemSourceProperty, value); }
        }
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemSourceProperty =
            DependencyProperty.Register("ItemSource", typeof(List<RaderModel>), typeof(RaderUC));


        /// <summary>
        /// 画图方法
        /// </summary>
        public void Drag()
        {
            //1.判断是否有数据
            if (ItemSource == null || ItemSource.Count==0)
            {
                //返回，什么都不做！
                return;
            }
            //2.清空以前画布内容
            //清空canvas内容
            mainCanvas.Children.Clear();
            //清空每个图形点
            P1.Points.Clear();
            P2.Points.Clear();
            P3.Points.Clear();
            P4.Points.Clear();
            P5.Points.Clear();
            //3.获取渲染器高/宽最小值（保证是个正方形）
            //问题：渲染器是啥东西？如果把这个用户控件放在一个Panel里面，那么这个渲染器的宽和高就是这个Panel的宽和高；
            //我们放在groupbox里面，所以高和宽就是这个groupbox 的高和宽；
            double size = Math.Min(RenderSize.Width, RenderSize.Height);

            //4.设置Grid的宽，高（保证是渲染器的最小值，渲染器可能是长方形，保证Grid是个正方形）
           
            LayGrid.Width = size;
            LayGrid.Height = size;
            //5.定义半径
            double radius = size / 2;
            //6.定义角度 (有几条数据，就有几条边，得到响应角度)
            double step = 360 / ItemSource.Count;
            //开始画图
            for (int i = 0; i < ItemSource.Count; i++)
            {
                //画最外面的图形 
                //定位图形的定点 X:radius-20为了调整图形是否美观， step-90为了把钝角变为锐角
                //Y: 和X相同，把cos变成 sin;
                //P1.Points.Add(new Point(radius + (radius - 20) * Math.Cos(step - 90) * Math.PI / 180,radius+(radius-20)*Math.Sin(step-90)*Math.PI/180));             
                //一共画4层，每层之间的间隙相同 0.25；
                //定位每个图形的定点；
                double x = 1.0;//最外层 x
                double y = 1.0;//最外层 y
                                
                x = (radius - 20) * Math.Cos((step*i - 90) * Math.PI / 180);//理解为顶点,基于半径，x偏移量
                y = (radius -20) * Math.Sin((step*i - 90) * Math.PI / 180);//基于半径，顶点y偏移量
                P1.Points.Add(new Point(radius +x, radius + y));//最外层 设置1
                P2.Points.Add(new Point(radius + x * 0.75, radius + y * 0.75));//第二层 0.75倍 x,y
                P3.Points.Add(new Point(radius + x * 0.5, radius + y*0.5));//第三层 0.5倍 x,y
                P4.Points.Add(new Point(radius + x * 0.25, radius + y*0.25));//第四层 0.25 倍 x,y;

                //数据多边形 不规则，偏移量根据数据值变化，记得除以100（0.01） 转化为百分数； 

               P5.Points.Add(new Point(radius + x *ItemSource[i].Value*0.01, radius + y *ItemSource[i].Value*0.01));

                //增加文本显示内容
                TextBlock textBlock = new TextBlock();
                textBlock.FontSize=10;
                textBlock.Width = 60;
                textBlock.TextAlignment =TextAlignment.Center;
                textBlock.Text = ItemSource[i].ItemName;
                textBlock.Foreground=new SolidColorBrush(Color.FromArgb(100, 255, 255, 255));
                textBlock.SetValue(Canvas.LeftProperty, radius + (radius - 10) * Math.Cos((step * i - 90) * Math.PI / 180) - 30);//设置左侧距离
                textBlock.SetValue(Canvas.TopProperty, radius + (radius - 10) * Math.Sin((step * i - 90) * Math.PI / 180) - 7);//设置上面距离；
                 
                //加入控件到画布；

                mainCanvas.Children.Add(textBlock);
            }



        }

    }
}
