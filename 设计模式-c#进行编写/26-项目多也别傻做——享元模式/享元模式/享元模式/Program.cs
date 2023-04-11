using System;

namespace 享元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            WebsiteFactory factory = new WebsiteFactory();

            Website website1 = factory.GetWebsite("博客");
            website1.Use(new User("小菜"));

            Website website2 = factory.GetWebsite("博客");
            website1.Use(new User("大鸟"));

            Website website3 = factory.GetWebsite("产品展示");
            website1.Use(new User("娇娇"));

            Website website4 = factory.GetWebsite("产品展示");
            website1.Use(new User("乐乐"));

            Website website5 = factory.GetWebsite("产品展示");
            website1.Use(new User("哈哈"));


            factory.GetWebsiteCount();

        }
    }
}
