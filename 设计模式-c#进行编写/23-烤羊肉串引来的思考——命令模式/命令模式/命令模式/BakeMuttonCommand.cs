﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver)
        {
        }
        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }
}
