using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式.数据类
{
    class SqlserverDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("从Sql Server中得到一条记录");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在Sql Server插入一条记录");
        }
    }
}
