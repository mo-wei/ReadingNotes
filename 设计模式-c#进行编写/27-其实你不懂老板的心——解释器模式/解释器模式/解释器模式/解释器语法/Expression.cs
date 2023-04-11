using System;
using System.Collections.Generic;
using System.Text;

namespace 解释器模式.解释器语法
{
    //解释器
    abstract class Expression
    {
        public void Interpret(PlayContext playContext)
        {
            if (playContext.Context.Length == 0)
            {
                return;
            }
            else
            {
                string playKey = playContext.Context.Substring(0, 1);
                playContext.Context = playContext.Context.Substring(2);
                double playValue = Convert.ToDouble(playContext.Context.Substring(0, playContext.Context.IndexOf(" ")));
                playContext.Context = playContext.Context.Substring(playContext.Context.IndexOf(" ") + 1);

                Excute(playKey, playValue);
            }

        }
        //执行
        public abstract void Excute(string key, double value);
    }
}
