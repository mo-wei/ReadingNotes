using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式.数据类
{
    class SqlserverUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在SQL Server中给User表增加一条记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("SQL Server中给User表增加一条记录");
        }
    }
}
