using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 生产监控系统.Models
{
    class AlarmModel
    {
        //报警编号
        public string Num { get; set; }
        //报警描述
        public string Msg { get; set; }

        //报警时间
        public string Time { get; set; }

        //警报时长 单位秒
        public int During { get; set; }

    }
}
