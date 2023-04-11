using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式.Last
{
    //所有运算类的基类，运算类都需要继承这个基类
    class Operation
    {
        //抽象出来的所有子类都需要的属性
        private double numberA;
        private double numberB;
        public double NumberA
        {
            get
            {
                return numberA;
            }
            set
            {
                numberA = value;
            }
        }
        public double NumberB
        {
            get
            {
                return numberB;
            }
            set
            {
                numberB = value;
            }
        }
        //子类需要重写的虚函数
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    //如果要加运算，只需要扩充相应计算类继承总的计算类即可
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result;
            result = NumberA + NumberB;
            return result;
        }
    }

    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result;
            result = NumberA - NumberB;
            return result;
        }
    }
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if(NumberB == 0)
            {
                throw new Exception("除数不能为0。");
            }
            result = NumberA / NumberB;
            return result;
        }
    }


}


