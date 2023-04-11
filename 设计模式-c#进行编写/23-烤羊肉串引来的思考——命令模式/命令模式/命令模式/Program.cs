using System;

namespace 命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbecuer boy = new Barbecuer();
            BakeChickenWingCommand bakeChicken = new BakeChickenWingCommand(boy);
            BakeMuttonCommand bakeMutton = new BakeMuttonCommand(boy);

            Waiter girl = new Waiter();


            girl.SetOrder(bakeMutton);
            girl.SetOrder(bakeMutton);
            girl.SetOrder(bakeMutton);

            girl.SetOrder(bakeChicken);
            girl.SetOrder(bakeChicken);

            girl.CancleOrder(bakeMutton);

            girl.Notify();


        }
    }
}
