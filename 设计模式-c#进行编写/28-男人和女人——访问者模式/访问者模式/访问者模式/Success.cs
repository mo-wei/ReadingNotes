﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 访问者模式
{
    class Success : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}时，背后多半有一个伟大的女人。",
                concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}时，背后大多有一个不成功的男人。",
               concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
