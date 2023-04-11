using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式.迭代器
{
    //聚集抽象类
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
