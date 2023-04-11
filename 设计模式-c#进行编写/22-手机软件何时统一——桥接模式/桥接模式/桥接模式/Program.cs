using System;
using 桥接模式.手机类;
using 桥接模式.软件类;
namespace 桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            HandSet handset = new HandBrandN();

            handset.SetHandSetSoft(new HandSetGame());
            handset.Run();

            handset.SetHandSetSoft(new HandSetAddressList());
            handset.Run();
        }
    }
}
