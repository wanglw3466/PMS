using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using 生产监控系统.Command;
using 生产监控系统.Models;
using 生产监控系统.UserControls;

namespace 生产监控系统.ViewModels
{
    //继承通知接口
    class MainVeiwModel:INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //生成构造函数，初始化环境Model
        public MainVeiwModel()
        {
            #region 初始化环境数据
            EnvironmentModel = new List<EnvironmentModel>();
            EnvironmentModel.Add(
                //技巧1：简化初始，属性值
                new EnvironmentModel()
                {
                    environmentName = "光照（Lux)",
                    environmentValue = 123
                }
            );
            EnvironmentModel.Add(
                new EnvironmentModel()
                {
                    environmentName = "噪音(db)",
                    environmentValue = 55
                }
                );
            EnvironmentModel.Add(new EnvironmentModel()
            {
                environmentName="温度(℃)",
                environmentValue=80
            });

            EnvironmentModel.Add(new EnvironmentModel()
            {
                environmentName = "湿度(%)",
                environmentValue = 43
            });

            EnvironmentModel.Add(new EnvironmentModel()
            {
                environmentName = "PM2.5(m³)",
                environmentValue = 15
            });

            EnvironmentModel.Add(new EnvironmentModel()
            {
                environmentName="硫化氢(PPM)",
                environmentValue=123
            });
            EnvironmentModel.Add(new EnvironmentModel()
            {
                environmentName = "氮气(ppm)",
                environmentValue=18
            });

            EnvironmentModel.Add(new EnvironmentModel()
            {
                environmentValue = 11,
                environmentName = "Test1"
            }
             );
            EnvironmentModel.Add(new EnvironmentModel()
            {

                environmentName = "Test2",
                environmentValue = 332
            });
            #endregion
            #region 初始化报警数据
            AlarmModels = new List<AlarmModel>();
            AlarmModels.Add(new AlarmModel() { Num = "01", Msg = "设备温度过高", Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), During = 7 });
            AlarmModels.Add(new AlarmModel() { Num = "02", Msg = "车间温度过高", Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), During = 10 });
            AlarmModels.Add(new AlarmModel() { Num = "03", Msg = "设备转速过快", Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), During = 12 });
            AlarmModels.Add(new AlarmModel() { Num = "04", Msg = "设备气压偏低", Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), During = 90 });
            #endregion
            #region 初始化设备数据
            DeviceModels = new List<DeviceModel>();
            DeviceModels.Add(new DeviceModel() { paraName="电能(Kw.h)",paraValue="60.8" });
            DeviceModels.Add(new DeviceModel() { paraName="电压(V)",paraValue="390" });
            DeviceModels.Add(new DeviceModel() { paraName = "压差(kpa)", paraValue = "13" });
            DeviceModels.Add(new DeviceModel() { paraName = "温度(℃)", paraValue = "36" });
            DeviceModels.Add(new DeviceModel() { paraName="震动(mm/s)",paraValue="4.1"});
            DeviceModels.Add(new DeviceModel() {paraName="转速(r/m)",paraValue="2600" });
            DeviceModels.Add(new DeviceModel() { paraName="气压(kpa)",paraValue="0.5"});
            #endregion
            #region 初始化雷达数据
            RaderModels = new List<RaderModel>();
            RaderModels.Add(new RaderModel() { ItemName="排烟风机", Value=90 });
            RaderModels.Add(new RaderModel() { ItemName="客梯",Value=30.00});
            RaderModels.Add(new RaderModel() { ItemName = "供水机", Value = 34.89 });
            RaderModels.Add(new RaderModel() {ItemName="喷淋水泵",Value=69.59 });
            RaderModels.Add(new RaderModel() { ItemName = "稳压设备", Value = 20 });
            //RaderModels.Add(new RaderModel() { ItemName = "稳压设备6", Value =65});
            #endregion

            #region 初始化缺岗数据
            StaffOutWorkModels = new List<StaffOutWorkModel>();
            StaffOutWorkModels.Add(new StaffOutWorkModel() {  StaffName="张婷婷", StaffPosition="技术员", OutWorkCount=123});
            StaffOutWorkModels.Add(new StaffOutWorkModel() { StaffName = "李晓", StaffPosition = "操作员", OutWorkCount = 23 });
            StaffOutWorkModels.Add(new StaffOutWorkModel() { StaffName = "王克俭", StaffPosition = "技术员", OutWorkCount=134 });
            StaffOutWorkModels.Add(new StaffOutWorkModel() { StaffName = "陈家栋", StaffPosition = "统计员", OutWorkCount = 143 });
            StaffOutWorkModels.Add(new StaffOutWorkModel() { StaffName="杨过",StaffPosition="技术员",OutWorkCount=12});
            #endregion

            #region 初始化车间数据
            WorkShopModels = new List<WorkShopModel>();
            WorkShopModels.Add(new WorkShopModel() { WorkShopName="贴片车间",WorkingCount=32,WaitingCount=8, WrongCount=4,StopCount=0});
            WorkShopModels.Add(new WorkShopModel() { WorkShopName= "封装车间", WorkingCount =20, WaitingCount =8, WrongCount =4, StopCount =0});
            WorkShopModels.Add(new WorkShopModel() { WorkShopName = "焊接车间", WorkingCount =32, WaitingCount =10, WrongCount =4, StopCount =10});
            WorkShopModels.Add(new WorkShopModel() { WorkShopName = "贴片车间", WorkingCount =68, WaitingCount=8, WrongCount =4, StopCount =0});
            #endregion

            #region 实例化ICommand
            //ShowCommand = new DetailCommand(showShopDetail);
            #endregion

        }

        private UserControl _MonitorUC;
        public UserControl MonitorUC
        {
            get { 
                if(_MonitorUC==null)
                {
                    //使用父类对象指针指向子类对象；
                    _MonitorUC = new MonitorUC();
                }
                return _MonitorUC; }
            set {
                _MonitorUC = value;
                if(PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("MonitorUC"));
                }
            }
        }

        #region 时间定义
        //定义小时 分钟属性 直接在用户控件中绑定，因为用户控件属于主界面，所以可以直接绑定。
        public string TimeStr
        {
            get
            {
                return DateTime.Now.ToString("HH:mm");
            }
        }
        //定义日期 属性
        public string DateStr
        {
            get
            {
                return DateTime.Now.ToString("yyyy-MM-dd");
            }

        }
        //定义星期几
        public string WeekStr
        {
            get
            {
                return DateTime.Now.ToString("dddd");
            }
        }

        //定义机台总数
        private string _MachineCount="0289";
       #endregion
        #region 生产计数定义
        public string MachineCount
        {
            get { return _MachineCount; }
            set {
                _MachineCount = value; 
                if(PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("MachineCount"));
                }
            }
        }
 


        //生产计数
        private string _ProductCount="1546";

        public string ProductCount
        {
            get { return _ProductCount; }
            set { _ProductCount = value;
            if(PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ProductCount"));
                }
            }
        }
        //不良计数
        private string _BadCount="01245";

        public string BadCount
        {
            get { return _BadCount; }
            set { _BadCount = value;
                if(PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("BadCount"));
                }
            }
        }

        #endregion

        #region 环境变量定义

        private List<EnvironmentModel>  _EnvironmentModel;



        public List<EnvironmentModel> EnvironmentModel  
        {
            get { return _EnvironmentModel; }
            set { _EnvironmentModel = value;
            if(PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("EnvironmentModel"));
                }
            }
        }


        #endregion

        #region 报警数据
        //报警集合
        private List<AlarmModel> _AlarmModels;
        public List<AlarmModel> AlarmModels
        {
            get { return _AlarmModels; }
            set { 
                
                _AlarmModels = value;
                if(PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("AlarmModels"));
                }
            
            }
        }
        #endregion

        #region 设备数据
        private List<DeviceModel> _DeviceModels;

        public List<DeviceModel> DeviceModels
        {
            get { return _DeviceModels; }
            set { _DeviceModels = value;
            if(PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("DeviceModels"));
                }
            }
        }
        #endregion

        #region 雷达数据
        private List<RaderModel> _RaderModels;

        public List<RaderModel> RaderModels
        {
            get { return _RaderModels; }
            set { _RaderModels = value;
            if(PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("RaderModels"));
                }
            }
        }

        #endregion

        #region 缺岗数据
        private List<StaffOutWorkModel> _StaffOutWorkModels;


        public List<StaffOutWorkModel> StaffOutWorkModels
        {
            get { return _StaffOutWorkModels; }
            set { _StaffOutWorkModels = value;
                if(PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("StaffOutWorkModels"));
                }
            }

        }

        #endregion

        #region 车间数据
        private List<WorkShopModel> _WorkShopModels;

        public List<WorkShopModel> WorkShopModels
        {
            get { return _WorkShopModels; }
            set {
                _WorkShopModels = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("WorkShopModels"));
                }
            }
        }


        #endregion



        ///// <summary>
        ///// 把事件绑定放在ViewModel中不起作用，不知道为啥？只能移动到MainWindow
        ///// </summary>
        ////定义事件
        //public void showShopDetail()
        //{
        //    this.MonitorUC = new WorkShopDetailUC();
        //}
        ////绑定事件
        //public ICommand ShowCommand { get; private set; }

        //public ICommand ShowCommand
        //{
        //    get
        //    {
        //        return new DetailCommand(showShopDetail);
        //    }
        //}


    }
}
