using System;

namespace 访问者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure o = new ObjectStructure();
            o.Attach(new Man());
            o.Attach(new Woman());


            Success v1 = new Success();
            o.Display(v1);

            Falling v2 = new Falling();
            o.Display(v2);

            Console.Read();
        }
    }
}
