using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.收费方式类
{
    class CashReturn : CashSuper
    {
        private double moneyCondition;//满减所需
        private double moneyReturn;//满减可减
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }
        public override double AcceptCash(double money)
        {
            if (money >= moneyCondition)
            {
                money -= Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return money;
        }
    }
}
