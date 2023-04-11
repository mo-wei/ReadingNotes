using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    abstract class Command
    {
        protected  Barbecuer receiver;

        public Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }

        abstract public void ExcuteCommand();
    }
}
