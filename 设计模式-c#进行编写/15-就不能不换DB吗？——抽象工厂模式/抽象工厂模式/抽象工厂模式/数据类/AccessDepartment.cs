using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式.数据类
{
    class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("从Access中获得一条记录");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("从Access中插入一条记录");
        }
    }
}
