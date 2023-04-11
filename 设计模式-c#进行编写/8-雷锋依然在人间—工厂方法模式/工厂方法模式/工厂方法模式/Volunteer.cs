using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式
{
    class Volunteer : LeiFeng
    {
        public override void BuyRice()
        {
            Console.WriteLine("志愿者帮忙买米");
        }

        public override void Sweep()
        {
            Console.WriteLine("志愿者帮忙打扫");
        }

        public override void Wash()
        {
            Console.WriteLine("志愿者帮忙洗衣");
        }
    }
}
