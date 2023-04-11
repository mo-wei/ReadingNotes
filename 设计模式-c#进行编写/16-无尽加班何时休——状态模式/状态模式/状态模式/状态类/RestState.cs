using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式.状态类
{
    class RestState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点下班回家了",w.Hour);
        }
    }
}
