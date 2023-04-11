using System;
using System.Collections.Generic;
using System.Text;

namespace 外观模式.股票类
{
    class NationalDebt
    {
        public void Sell()
        {
            Console.WriteLine("卖出国债");
        }

        public void Buy()
        {
            Console.WriteLine("买入国债");
        }
    }
}
