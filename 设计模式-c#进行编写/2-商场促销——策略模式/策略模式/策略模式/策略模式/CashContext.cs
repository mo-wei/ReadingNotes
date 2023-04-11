using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 策略模式.收费方式类;
namespace 策略模式.策略模式
{
    class CashContext
    {
        private CashSuper cs = null;

        public CashContext(String type)
        {
            switch(type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "打八折":
                    cs = new CashRebate("0.8");
                    break;
                case "满三百减一百":
                    cs = new CashReturn("300", "100");
                    break;
                default:
                    break;
            }
        }
        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }

    }
}
