using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    class Waiter
    {
        private IList<Command> oders = new List<Command>();

        public void SetOrder(Command command)
        {

            if(command.ToString() == "命令模式.BakeChickenWingCommand")//假设鸡翅没有了
            {
                Console.WriteLine("鸡翅已经卖完了");
            }
            else
            {
                oders.Add(command);
                Console.WriteLine("增加订单：" + command.ToString() + "时间：" + DateTime.Now.ToString());
            }
        }

        public void CancleOrder(Command command)
        {
            oders.Remove(command);
            Console.WriteLine("取消订单：" + command.ToString() + "时间：" + DateTime.Now.ToString());
        }

        public void Notify()
        {
            foreach(var cam in oders)
            {
                cam.ExcuteCommand();
            }
        }
    }
}
