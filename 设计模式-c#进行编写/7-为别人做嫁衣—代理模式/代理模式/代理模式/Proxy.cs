using System;
using System.Collections.Generic;
using System.Text;

namespace 代理模式
{
    class Proxy : GiveGift
    {
        private Pursuit pursuit;

        public Proxy(SchoolGirl girl)
        {
            this.pursuit = new Pursuit(girl);
        }
        public void GiveChocolate()
        {
            pursuit.GiveChocolate();
        }

        public void GiveDoll()
        {
            pursuit.GiveDoll();
        }

        public void GiveFlower()
        {
            pursuit.GiveFlower();
        }
    }
}
