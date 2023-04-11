using System;
using 抽象工厂模式.数据类;
namespace 抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //数据库用户和地址的读取和插入
            User user = new User();
            Department department = new Department();

            IUser iu = DataAccess.CreateUser();

            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = DataAccess.CreateDepartment();
            id.Insert(department);
            id.GetDepartment(1);

            Console.Read();
        }
    }
}
