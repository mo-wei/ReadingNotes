using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式.迭代器
{
    class Concreteiterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public  Concreteiterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if(current < aggregate.Count)
            {
                ret = aggregate[current];
            }
            return ret;
        }
    }
}
