using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 生产监控系统.Models
{
public  class StaffOutWorkModel
    {
        //姓名
        public string StaffName { get; set; }
        //职位
        public string StaffPosition { get; set; }
        //缺岗次数
        public int OutWorkCount { get; set; }
        //按照比例缩小缺岗次数，用来显示方便

        public int ShowWidth {
            get
            {
                return OutWorkCount *70/100;
            }
        }
    }
}
