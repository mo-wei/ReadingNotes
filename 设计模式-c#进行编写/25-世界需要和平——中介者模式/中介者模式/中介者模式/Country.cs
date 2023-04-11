using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    abstract class Country
    {
        protected UnitedNation unitedNation;

        public Country(UnitedNation unitedNation)
        {
            this.unitedNation = unitedNation;
        }
    }
}
