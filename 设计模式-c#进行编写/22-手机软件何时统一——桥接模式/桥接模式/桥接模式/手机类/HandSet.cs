using System;
using 桥接模式.软件类;

namespace 桥接模式.手机类
{
    abstract class HandSet
    {
        protected HandSetSoft soft;

        public void SetHandSetSoft(HandSetSoft soft)
        {
            this.soft = soft;
        }
        public abstract void Run();
    }
}
