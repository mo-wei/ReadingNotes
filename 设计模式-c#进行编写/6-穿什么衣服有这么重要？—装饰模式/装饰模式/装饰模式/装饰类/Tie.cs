using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰模式.装饰类
{
    class Tie : Finery
    {
        public override void Show()
        {
            Console.Write("  领带  ");
            base.Show();
        }
    }
}
