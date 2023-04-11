using System;
using System.Collections.Generic;
using System.Text;

namespace 组合模式
{
    class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name)
        {
        }
        public override void Add(Company c)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 公司财政收支管理", name);
        }

        public override void Remove(Company c)
        {
        }
    }
}
