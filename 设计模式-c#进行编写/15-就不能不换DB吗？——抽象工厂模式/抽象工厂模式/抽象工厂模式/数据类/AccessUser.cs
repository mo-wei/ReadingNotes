using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式.数据类
{
    class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("从Access中得到一条记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("Access中给User表增加一条记录");

        }
    }
}
