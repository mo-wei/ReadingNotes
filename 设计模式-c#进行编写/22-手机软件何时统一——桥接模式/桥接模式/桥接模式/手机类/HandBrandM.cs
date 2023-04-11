using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式.手机类
{
    class HandBrandM : HandSet
    {
        public override void Run()
        {
            Console.WriteLine("这里是M手机");
            soft.Run();
        }
    }
}
