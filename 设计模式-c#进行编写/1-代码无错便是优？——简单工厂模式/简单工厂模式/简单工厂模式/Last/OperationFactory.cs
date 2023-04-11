using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式.Last
{
    /// <summary>
    /// 算法工厂类，能够加工出相应的算法
    /// </summary>
    class OperationFactory
    {
        public static Operation CreatOperation(string operate)
        {
            //根据传入的信息，工厂会加工出对应的运算产品出来
            Operation oper = null;
            switch(operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }
            return oper;
        }


    }
}
