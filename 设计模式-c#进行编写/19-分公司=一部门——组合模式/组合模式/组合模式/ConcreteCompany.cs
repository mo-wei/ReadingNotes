using System;
using System.Collections.Generic;
using System.Text;

namespace 组合模式
{
    class ConcreteCompany : Company
    {
        private List<Company> children = new List<Company>();

        public ConcreteCompany(string name): base(name)
        {

        }
        public override void Add(Company c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (var component in children)
            {
                component.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
        }

        public override void Remove(Company c)
        {
        }
    }
}
