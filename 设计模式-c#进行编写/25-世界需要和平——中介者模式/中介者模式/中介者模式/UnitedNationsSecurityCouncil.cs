using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    class UnitedNationsSecurityCouncil : UnitedNation
    {
        public USA country1 { get; set; }
        public Iraq country2 { get; set; }
        public override void Declare(string massage, Country country)
        {
            if(country == country1)
            {
                country2.GetMassage(massage);
            }
            else
            {
                country1.GetMassage(massage);
            }
        }
    }
}
