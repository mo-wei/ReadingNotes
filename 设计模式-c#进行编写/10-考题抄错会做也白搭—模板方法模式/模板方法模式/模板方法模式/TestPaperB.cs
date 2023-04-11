
namespace 模板方法模式
{
    /// <summary>
    /// 学生B的试卷
    /// </summary>
    class TestPaperB : TestPaper
    {
        protected override string Answer1()
        {
            return "a";
        }
        protected override string Answer2()
        {
            return "a";
        }
        protected override string Answer3()
        {
            return "c";
        }
    }
}
