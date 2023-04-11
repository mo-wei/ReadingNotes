using System;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();
            StockObserver colleague1 = new StockObserver("魏", boss);
            NBAObserver colleague2 = new NBAObserver("易", boss);

            boss.Update += new EventHandler(colleague1.CloseStockMacket);
            boss.Update += new EventHandler(colleague2.CloseNBADirectSeeding);
            boss.SubjectState = "我胡汉三回来了";
            boss.Notify();
        }
    }
}
