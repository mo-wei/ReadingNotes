using System;
using System.Collections.Generic;
using System.Text;

namespace 组合模式
{
    abstract class Company
    {

        protected string name;
        public Company(string name)
        {
            this.name = name;
        }

        public abstract void Add(Company c);
        public abstract void Remove(Company c);
        public abstract void Display(int depth);
        //增加了一个履行职责,此处可以不同类实现不同功能
        public abstract void LineOfDuty();
    }
}
