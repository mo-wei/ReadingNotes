
using System;
using System.Collections.Generic;
using System.Text;

namespace 外观模式.股票类
{
    //股票
    class Stock1
    {
        //卖股票
        public void Sell()
        {
            Console.WriteLine("股票1卖出");
        }
        //买股票
        public void Buy()
        {
            Console.WriteLine("股票1买入");
        }

    }
}
