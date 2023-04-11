using System;
using System.Collections.Generic;
using System.Text;

namespace 访问者模式
{
    abstract class Action
    {
        public abstract void GetManConclusion(Man concreteElementA);
        public abstract void GetWomanConclusion(Woman concreteElementB);
    }
}
