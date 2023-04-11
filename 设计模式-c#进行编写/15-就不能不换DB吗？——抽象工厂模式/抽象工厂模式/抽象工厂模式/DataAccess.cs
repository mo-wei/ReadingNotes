using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using 抽象工厂模式.数据类;
using System.Configuration;

namespace 抽象工厂模式
{
    class DataAccess
    {
        private static readonly string AssemblyName = "抽象工厂模式";
        private static readonly string LevelName = "数据类";
        
        
        //private static readonly string db = "Access"; //不用配置文件
        private static readonly string db = ConfigurationManager.AppSettings["DB"]; //使用配置文件

        public static IUser CreateUser()
        {
            string className = AssemblyName + "." + LevelName + "."+ db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            //string className = AssemblyName + "." + db + "Department";
            string className = AssemblyName + "." + LevelName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
