using System;
using System.Collections.Generic;
using System.Text;

namespace 访问者模式
{
    abstract class Person
    {
        public abstract void Accept(Action visitor);
    }
}
