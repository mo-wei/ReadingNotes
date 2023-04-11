using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式.数据类
{
    interface IDepartment
    {
        void Insert(Department department);

        Department GetDepartment(int id);
    }
}
