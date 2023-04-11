using System;

namespace 装饰模式.装饰类
{
    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("  跨裤  ");
            base.Show();
        }
    }
}
