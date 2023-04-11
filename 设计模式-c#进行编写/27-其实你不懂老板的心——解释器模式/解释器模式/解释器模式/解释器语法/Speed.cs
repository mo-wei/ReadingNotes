using System;
using System.Collections.Generic;
using System.Text;

namespace 解释器模式.解释器语法
{
    class Speed : Expression
    {
        public override void Excute(string key, double value)
        {
            string speed = "";
            if(value < 500)
            {
                speed = "低速";
            }
            else if(value >= 500 && value < 1000)
            {
                speed = "中速";
            }
            else
            {
                speed = "高速";
            }
            Console.Write("{0} ", speed);
        }
    }
}
