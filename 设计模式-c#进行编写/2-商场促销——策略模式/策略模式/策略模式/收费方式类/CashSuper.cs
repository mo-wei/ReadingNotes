using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    abstract class CashSuper
    {
        public abstract double AcceptCash(double money);
    }
}
