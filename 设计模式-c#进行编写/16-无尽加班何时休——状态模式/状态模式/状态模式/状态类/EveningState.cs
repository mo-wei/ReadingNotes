using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式.状态类
{
    class EveningState : State
    {
        public override void WriteProgram(Work w)
        {
            if(w.Finished)
            {
                w.SetState(new RestState());
                w.WriteProgram();
            }
            else
            {
                if (w.Hour < 21)
                {
                    Console.WriteLine("当前时间：{0}点 加班哦，疲累之极",w.Hour);
                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WriteProgram();
                }
            }
            
        }
    }
}
