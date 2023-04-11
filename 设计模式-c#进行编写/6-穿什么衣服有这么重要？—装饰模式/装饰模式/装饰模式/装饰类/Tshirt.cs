using System;

namespace 装饰模式.装饰类
{
    class Tshirt : Finery
    {
        public override void Show()
        {
            Console.Write("  T恤  ");
            base.Show();
        }
    }
}
