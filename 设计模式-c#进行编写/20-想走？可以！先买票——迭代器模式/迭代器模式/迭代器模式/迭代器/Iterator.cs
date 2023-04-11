using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式.迭代器
{
    //迭代器抽象类
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();


    }
}
