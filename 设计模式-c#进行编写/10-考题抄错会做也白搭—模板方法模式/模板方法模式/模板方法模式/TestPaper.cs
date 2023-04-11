using System;

namespace 模板方法模式
{
    /// <summary>
    /// 金庸小说考题试卷
    /// </summary>
    class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("杨过得到，后来给了郭靖，练成倚天剑，屠龙刀的玄铁可能是【】 A.球磨铸铁 B.马口铁 C.高速合金钢 D.碳素纤维 ");
            Console.WriteLine("答案：" + Answer1());
        }

        protected virtual string Answer1()
        {
            return "";
        }

        public void TestQuestion2()
        {
            Console.WriteLine("杨过、程英、陆无双铲除了情花，造成【】 A.使这种植物不再害人 B.使一种珍稀物种灭绝 C.破坏了那个生物圈的生态平衡 D.造成该地区沙漠化");
            Console.WriteLine("答案：" + Answer2());

        }

        protected virtual string Answer2()
        {
            return "";
        }

        public void TestQuestion3()
        {
            Console.WriteLine("蓝凤凰致使华山师徒、桃谷六仙呕吐不止，如果你是大夫，会给他们开什么药【】 A.阿司匹林 B.牛黄解毒片 C.氟哌酸 D.让他们喝大量的生牛奶 E.以上全不对");
            Console.WriteLine("答案：" + Answer3());

        }

        protected virtual string Answer3()
        {
            return "";
        }
    }
}
