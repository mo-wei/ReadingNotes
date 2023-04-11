using System;

namespace 简单工厂模式.First
{
    /// <summary>
    /// 新手才上手时会写的计算器
    /// </summary>
    class Level1
    {
        static void Main(string[] args)
        {
            //
            //、B、C命名不规范
            Console.Write("请输入数字A：");
            String A = Console.ReadLine();
            Console.Write("请选择运算符号(+、-、*、/)：");
            string B = Console.ReadLine();
            Console.Write("请输入数字B：");
            string C = Console.ReadLine();
            string D = "";

            //判断分支全用if，会做无用功
            if(B == "+")
            {
                D = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble(C));
            }
            if (B == "-")
            {
                D = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble(C));
            }
            if (B == "*")
            {
                D = Convert.ToString(Convert.ToDouble(A) * Convert.ToDouble(C));
            }
            //没用规范用户输入0的情况
            if (B == "/")
            {
                D = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble(C));
            }
            Console.WriteLine("结果是：" + D);
        }
    }
}
