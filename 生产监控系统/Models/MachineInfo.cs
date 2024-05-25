using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 生产监控系统.Models
{
    internal class MachineInfo
    {
        //机器名称
        public string MachineName { get; set; }
        //机器状态
        public string MachineStatus { get; set; }

        //计划数量
        public  int  PlanCount { get; set; }

        //完成数量
        public int FinishedCount { get; set; }

        //工单
        public string Order { get; set; }

        //完成百分比  采用简化写法
        public double Percent => FinishedCount * 100.0 / PlanCount;

        //public double Percent
        //{
        //    get
        //    {
        //        return FinishedCount * 100 / PlanCount;
        //    }
        //}
    }
}
