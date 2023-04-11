using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.收费方式类
{
    class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;

        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }
        public override double AcceptCash(double money)
        {
            return money * this.moneyRebate;
        }
    }
}
