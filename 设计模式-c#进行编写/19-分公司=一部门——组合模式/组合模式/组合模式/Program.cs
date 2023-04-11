using System;
using System.Collections.Generic;

namespace 组合模式
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Composite root = new Composite("root");
             root.Add(new Leaf("Leaf A"));
             root.Add(new Leaf("Leaf B"));

             Composite comp = new Composite("Composite X");
             comp.Add(new Leaf("Leaf XA"));
             comp.Add(new Leaf("Leaf XB"));
             root.Add(comp);

             Composite comp2 = new Composite("Composite XY");
             comp2.Add(new Leaf("Leaf XYA"));
             comp2.Add(new Leaf("Leaf XYB"));
             root.Add(comp2);

             root.Add(new Leaf("Leaf C"));
             Leaf leaf = new Leaf("Leaf D");
             root.Add(leaf);
             root.Remove(leaf);

             root.Display(1);*/

            ConcreteCompany root = new ConcreteCompany("北京总公司");
            root.Add(new HRDepartment("总公司人力资源部"));
            root.Add(new FinanceDepartment("总公司财务部"));

            ConcreteCompany comp = new ConcreteCompany("Composite X");
            comp.Add(new HRDepartment("华东分公司人力资源部"));
            comp.Add(new FinanceDepartment("华东分公司公司财务部"));
            root.Add(comp);

            ConcreteCompany comp2 = new ConcreteCompany("Composite XY");
            comp2.Add(new HRDepartment("杭州分公司公司人力资源部"));
            comp2.Add(new FinanceDepartment("杭州分公司公司财务部"));
            root.Add(comp2);

            root.Display(1);

            root.LineOfDuty();
        }
    }

    /*//组合模式Test
    abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }

    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }
        public override void Add(Component c)
        {
            Console.WriteLine("Connot add to a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannont remove from a leaf");
        }
    }

    class ConcreteCompany : Component
    {
        private List<Component> children = new List<Component>();
        public ConcreteCompany(string name) : base(name)
        {

        }
        public override void Add(Component c)
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

        public override void Remove(Component c)
        {
            children.Remove(c);
        }
    }*/
}
