using System;

namespace 模板方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPaper student1 = new TestPaperA();
            student1.TestQuestion1();
            student1.TestQuestion2();
            student1.TestQuestion3();

            TestPaper student2 = new TestPaperB();
            student2.TestQuestion1();
            student2.TestQuestion2();
            student2.TestQuestion3();
        }
    }
}
