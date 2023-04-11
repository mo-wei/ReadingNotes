using System;

namespace 中介者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitedNationsSecurityCouncil unitedNation = new UnitedNationsSecurityCouncil();
            USA USA = new USA(unitedNation);
            Iraq Iraq = new Iraq(unitedNation);

            unitedNation.country1 = USA;
            unitedNation.country2 = Iraq;

            USA.Declare("不准使用核武器");
            Iraq.Declare("我们没有使用核武器，我们不怕你的侵略");
        }
    }
}
