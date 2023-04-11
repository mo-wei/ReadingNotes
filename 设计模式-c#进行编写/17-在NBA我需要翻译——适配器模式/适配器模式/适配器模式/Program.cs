using System;

namespace 适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Player b = new Forwards("巴蒂尔");
            b.Attack();
            Player m = new Guards("麦克格雷迪");
            m.Attack();
            Player ym = new Translator("姚明");
            ym.Attack();
            ym.Defense();
        }
    }
}
