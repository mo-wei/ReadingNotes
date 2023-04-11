using System;

namespace 模板方法模式
{
    /// <summary>
    /// 学生A的试卷
    /// </summary>
    class TestPaperA : TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("杨过得到，后来给了郭靖，练成倚天剑，屠龙刀的玄铁可能是【】 A.球磨铸铁 B.马口铁 C.高速合金钢 D.碳素纤维 ");
            Console.WriteLine("答案：" + "a");
        }

        public void TestQuestion2()
        {
            Console.WriteLine("杨过、程英、陆无双铲除了情花，造成【】 A.使这种植物不再害人 B.使一种珍稀物种灭绝 C.破坏了那个生物圈的生态平衡 D.造成该地区沙漠化");
            Console.WriteLine("答案：" + "b");

        }

        protected override string Answer1()
        {
            return "b";
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
