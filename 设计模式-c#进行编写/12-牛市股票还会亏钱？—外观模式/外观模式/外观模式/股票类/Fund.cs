
using System;

namespace 外观模式.股票类
{
    class Fund
    {
        private Stock1 stock1;
        private Stock2 stock2;
        private NationalDebt nationalDebt;
        private Realty realty;

        public Fund()
        {
            stock1 = new Stock1();
            stock2 = new Stock2();
            nationalDebt = new NationalDebt();
            realty = new Realty();
        }

        public void SellFund()
        {
            stock1.Sell();
            stock2.Sell();
            nationalDebt.Sell();
            realty.Sell();
        }

        public void BuyFund()
        {
            stock1.Buy();
            stock2.Buy();
            nationalDebt.Buy();
            realty.Buy();
        }

    }
}
