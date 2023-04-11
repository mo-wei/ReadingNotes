using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    class USA : Country
    {
        public USA(UnitedNation unitedNation) : base(unitedNation)
        {

        }

        public void Declare(string massage)
        {
            unitedNation.Declare(massage, this);
        }

        public void GetMassage(string massage)
        {
            Console.WriteLine("美国获得对方信息：" + massage);
        }
    }
}
