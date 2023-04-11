using System;
using System.Collections.Generic;
using System.Text;

namespace 代理模式
{
    class Pursuit : GiveGift
    {
        private SchoolGirl girl;

        public Pursuit(SchoolGirl girl)
        {
            this.girl = girl;
        }
        public void GiveChocolate()
        {
            Console.WriteLine(girl.Name + "送你巧克力");
        }

        public void GiveDoll()
        {
            Console.WriteLine(girl.Name + "送你洋娃娃");
        }

        public void GiveFlower()
        {
            Console.WriteLine(girl.Name + "送你花");
        }
    }
}
