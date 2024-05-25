using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 生产监控系统.Models
{
   public class WorkShopModel
    {
        //车间名称
        public string WorkShopName { get; set; }
        //作业数量

        public int WorkingCount { get; set; }
        //待机数量

        public int WaitingCount { get; set; }

        //故障数量
        public int WrongCount { get; set; }
        
        //停机数量
        public int StopCount { get; set; }

        //总数量(只读属性) 采用简略写法
        public int TotalCount =>  WorkingCount+WaitingCount+WrongCount+StopCount;
        //public int TotalCount
        //{
        //    get
        //    {
        //        return WorkingCount + WaitingCount + WrongCount + StopCount;
        //    }
        //}

    }
}
