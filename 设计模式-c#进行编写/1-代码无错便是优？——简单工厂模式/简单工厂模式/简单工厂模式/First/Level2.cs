using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂模式.First
{
    /// <summary>
    /// 新手改进后的程序，还没有设计模式
    /// </summary>
    class Level2
    {
        static void Main(string[] args)
        {
            //没有使用面向对象的设计模式，代码不够灵活
            try
            {
                Console.Write("请输入数字A：");
                String strNumberA = Console.ReadLine();
                Console.Write("请选择运算符号(+、-、*、/)：");
                string strOperate = Console.ReadLine();
                Console.Write("请输入数字B：");
                string strNumberB = Console.ReadLine();
                string strResult = "";
               
                switch (strOperate)
                {
                    case "+":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) + Convert.ToDouble(strNumberB));
                        break;
                    case "-":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB));
                        break;
                    case "*":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB));
                        break;
                    case "/":
                        if (strNumberB != "0")
                        {
                            strResult = Convert.ToString(Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB));
                        }
                        else
                        {
                            strResult = "除数不能为0";
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("结果是：" + strResult);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("您的输入有错：" + ex.Message);
            }
        }
    }
}
