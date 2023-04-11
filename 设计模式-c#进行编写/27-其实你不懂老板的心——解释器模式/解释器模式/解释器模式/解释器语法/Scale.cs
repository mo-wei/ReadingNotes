using System;
using System.Collections.Generic;
using System.Text;

namespace 解释器模式.解释器语法
{
    class Scale : Expression
    {
        public override void Excute(string key, double value)
        {
            string scale = "";
            switch (Convert.ToInt32(value))
            {
                case 1:
                    scale = "低音";
                    break;
                case 2:
                    scale = "中音";
                    break;
                case 3:
                    scale = "高音";
                    break;
            }
            Console.Write("{0} ", scale);
        }
    }
}
