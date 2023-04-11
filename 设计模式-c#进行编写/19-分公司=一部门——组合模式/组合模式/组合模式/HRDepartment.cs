using System;
using System.Collections.Generic;
using System.Text;

namespace 组合模式
{
    class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name)
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
            Console.WriteLine("{0} 员工招牌培训", name);
        }

        public override void Remove(Company c)
        {

        }
    }
}
