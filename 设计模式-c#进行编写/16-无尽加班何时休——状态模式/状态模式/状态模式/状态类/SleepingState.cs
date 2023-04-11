using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式.状态类
{
    class SleepingState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点不行了，睡着了", w.Hour);
        }
    }
}
