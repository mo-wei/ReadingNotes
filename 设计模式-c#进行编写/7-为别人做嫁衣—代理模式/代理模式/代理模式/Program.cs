using System;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl girl = new SchoolGirl();
            girl.Name = "心月 ";

            Proxy proxy = new Proxy(girl);
            proxy.GiveDoll();
            proxy.GiveChocolate();
            proxy.GiveFlower();
        }
    }
}
