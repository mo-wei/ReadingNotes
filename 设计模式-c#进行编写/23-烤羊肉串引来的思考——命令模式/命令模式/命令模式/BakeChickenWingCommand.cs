using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
        {

        }
        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
