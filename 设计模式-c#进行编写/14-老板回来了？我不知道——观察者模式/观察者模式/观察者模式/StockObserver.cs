using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    class StockObserver
    {
        private string name;
        private Subject sub;
        public StockObserver(string name, Subject subject)
        {
            this.name = name;
            this.sub = subject;
        }

        public void CloseStockMacket()
        {
            Console.WriteLine("{0}  {1} 关闭股票市场",sub.SubjectState, name);
        }
    }
}
