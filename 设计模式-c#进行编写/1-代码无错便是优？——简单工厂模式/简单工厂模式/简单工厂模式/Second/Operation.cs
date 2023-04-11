using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式.Second
{
    class Operation
    {
        public static double GetResult(double numberA, double numberB, string operate)
        {
            double result = 0d;
            switch (operate)
            {
                case "+":
                    result = numberA + numberB;
                    break;
                case "-":
                    result = numberA - numberB;
                    break;
                case "*":
                    result = numberA * numberB;
                    break;
                case "/":
                    if(numberB == 0)
                    {
                        throw new Exception("除数不能为0。");
                    }
                    result = numberA / numberB;
                    break;
            }
            return result;
        }
    }
}
