using System;
using 外观模式.股票类;
namespace 外观模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Fund fund = new Fund();
            fund.BuyFund();
            fund.SellFund();
            Console.Read();
        }
    }
}
