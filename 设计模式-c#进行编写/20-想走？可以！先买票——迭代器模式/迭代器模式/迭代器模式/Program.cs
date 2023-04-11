using System;
using System.Collections;
using System.Collections.Generic;
//自我实现的迭代器
using 迭代器模式.迭代器;
namespace 迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //自我实现迭代器Test
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "大鸟";
            a[1] = "小菜";
            a[2] = "行李";
            a[3] = "老外";
            a[4] = "公交车内部员工";
            a[5] = "小偷";

            //Iterator i = new Concreteiterator(a);
            Iterator i = new ConrecteiteratorDesc(a);
            object obj = i.First();
            while(!i.IsDone())
            {
                Console.WriteLine("{0} 请买车票！",i.CurrentItem());
                i.Next();
            }



            //.NET实现迭代器
            IList<string> b = new List<string>();
            b.Add("大鸟");
            b.Add("小菜");
            b.Add("行李");
            b.Add("老外");
            b.Add("公交内部员工");
            b.Add("小偷");

            //这里用的是foreach
            foreach(string item in b)
            {
                Console.WriteLine("{0} 请买车票!",item);
            }

            //其实foreach做的工作就是下面部分
            IEnumerator<string> e = b.GetEnumerator();

            while(e.MoveNext())
            {
                Console.WriteLine("{0} 请买车票!", e.Current);
            }
        }
    }
}
