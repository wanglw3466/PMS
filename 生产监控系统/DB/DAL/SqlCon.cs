using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 生产监控系统.DB.DAL
{
   
    //采用饿汉模式返回单例模式
    public class SqlCon
    {
        private static MySqlConnection _Instance=null;
        private static string sqlStr = "server=localhost;database=tran123;user=root;password=123456";
        private static object lock_obj=new object();

        public static MySqlConnection GetConnectionInstance()
        {
            if(_Instance==null )
            {
                //双重检查锁
                lock (lock_obj)
                {
                    if (_Instance == null)
                    {
                        _Instance = new MySqlConnection(sqlStr);
                        _Instance.Open();

                    }
                    else if(_Instance!=null && _Instance.State==System.Data.ConnectionState.Closed)
                    {
                        _Instance.Open();
                    }
                }
            }
            else if(_Instance!=null && _Instance.State == System.Data.ConnectionState.Closed)
            {
                _Instance.Open();
            }
            return _Instance;
        }


    }
}
