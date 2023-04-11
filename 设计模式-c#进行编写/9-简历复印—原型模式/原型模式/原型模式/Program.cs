using System;

namespace 原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("莫威");
            a.SetPersonalInfo("男", "20");
            a.SetWorkExperience("2024年9月", "华为");

            Resume b = (Resume)a.Clone();
            b.SetPersonalInfo("女", "24");

            Resume c = (Resume)a.Clone();
            c.SetWorkExperience("2025年10月", "软星");

            a.Display();
            b.Display();
            c.Display();
        }
    }
}
