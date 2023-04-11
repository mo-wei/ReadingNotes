using System;
using 工厂方法模式.工厂类;
namespace 工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new VolunteerFactory();//只需要改这一句话就可以创建不同的工厂
            //IFactory factory = new GraduateFactory();
            LeiFeng graduate = factory.CreatLeiFeng();

            graduate.BuyRice();
            graduate.Sweep();
            graduate.Wash();
        }
    }
}
