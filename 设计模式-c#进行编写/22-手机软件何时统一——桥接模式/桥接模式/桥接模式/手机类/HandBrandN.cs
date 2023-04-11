using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式.手机类
{
    class HandBrandN : HandSet
    {
        public override void Run()
        {
            Console.WriteLine("这里是手机N");
            soft.Run();
        }
    }
}
