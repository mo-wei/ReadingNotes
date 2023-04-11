using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    class Iraq : Country
    {
        public Iraq(UnitedNation unitedNation) : base(unitedNation)
        {

        }

        public void Declare(string massage)
        {
            unitedNation.Declare(massage, this);
        }

        public void GetMassage(string massage)
        {
            Console.WriteLine("伊拉克获得对方信息：" + massage);
        }
    }
}
