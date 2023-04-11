using System;
using System.Collections.Generic;
using System.Text;

namespace 工厂方法模式.工厂类
{
    class GraduateFactory : IFactory
    {
        public LeiFeng CreatLeiFeng()
        {
            return new Graduate();
        }
    }
}
