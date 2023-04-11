using System;
using System.Collections.Generic;
using System.Text;

namespace 享元模式
{
    class ConcreteWebsite : Website
    {
        private string name;

        public ConcreteWebsite(string name)
        {
            this.name = name;
        }
        public override void Use(User user)
        {
            Console.WriteLine("网站类型：" + name + "使用者：" + user.Name);
        }
    }
}
