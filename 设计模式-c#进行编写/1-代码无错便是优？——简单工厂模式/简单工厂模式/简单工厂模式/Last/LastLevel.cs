using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式.Last
{
    //实现简单工厂模式
    class LastLevel
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入数字A：");
                String strNumberA = Console.ReadLine();
                Console.Write("请选择运算符号(+、-、*、/)：");
                string strOperate = Console.ReadLine();
                Console.Write("请输入数字B：");
                string strNumberB = Console.ReadLine();
                string strResult = "";
                //只运用了面向对象的封装
                Operation oper;
                oper = OperationFactory.CreatOperation(strOperate);
                oper.NumberA = Convert.ToDouble(strNumberA);
                oper.NumberB = Convert.ToDouble(strNumberB);
                strResult = Convert.ToString(oper.GetResult());
                Console.WriteLine("结果是：" + strResult);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有误" + ex);
            }

        }
    }
}
