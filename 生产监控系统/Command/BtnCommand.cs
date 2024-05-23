using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace 生产监控系统.Command
{
    public class BtnCommand : ICommand

    {
        //定义一个无参数，无返回值 接口函数；
        private Action _Action;

        //初始化构造函数
        public BtnCommand(Action action)
        {
            this._Action = action;
        }

        public event EventHandler CanExecuteChanged;

        //返回TRUE，表示可以执行
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
             if(_Action!=null)
            {
                this._Action();//如何执行这个Action？
            }
        }
    }
}
