using 装饰模式.装饰类;
namespace 装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("小菜");

            BigTrouser bigTrouser = new BigTrouser();
            Tie tie = new Tie();
            Tshirt tshirt = new Tshirt();

            //按照装饰模式，就可以随意的搭配自己想要的部分了
            bigTrouser.Decorate(person1);
            tie.Decorate(bigTrouser);
            tshirt.Decorate(tie);
            tshirt.Show();

            //第二人也可以很快搭配好衣服

            Person person2 = new Person("大鸟");

            tie.Decorate(person2);
            tshirt.Decorate(tie);
            tshirt.Show();
        }
    }
}
