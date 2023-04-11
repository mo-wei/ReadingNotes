using System;

namespace 装饰模式.装饰类
{
    class Person
    {
        private string name;
        public Person() { }

        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("来装饰 {0}",name);
        }
    }
}
