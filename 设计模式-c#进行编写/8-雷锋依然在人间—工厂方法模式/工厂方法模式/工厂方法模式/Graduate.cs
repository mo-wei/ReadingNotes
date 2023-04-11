using System;

namespace 工厂方法模式
{
    class Graduate : LeiFeng
    {
        public override void BuyRice()
        {
            Console.WriteLine("大学生帮忙买米");
        }

        public override void Sweep()
        {
            Console.WriteLine("大学生帮忙打扫");
        }

        public override void Wash()
        {
            Console.WriteLine("大学生帮忙洗衣");
        }
    }
}
