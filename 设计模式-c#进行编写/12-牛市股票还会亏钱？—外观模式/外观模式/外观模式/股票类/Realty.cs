using System;
using System.Collections.Generic;
using System.Text;

namespace 外观模式.股票类
{
    class Realty
    {
        public void Sell()
        {
            Console.WriteLine("卖出房地产");
        }

        public void Buy()
        {
            Console.WriteLine("买入房地产");
        }
    }
}
