using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式.迭代器
{
    class ConrecteiteratorDesc : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0; 
        public ConrecteiteratorDesc(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
            current = aggregate.Count - 1;
        }
        public override object CurrentItem()
        {
            return aggregate[current];
        }


        public override object First()
        {
            return aggregate[aggregate.Count - 1];
        }

        public override bool IsDone()
        {
            return current < 0 ? true : false;
        }

        public override object Next()
        {
            object ret = null;
            current--;
            if(current >= 0)
            {
                ret = aggregate[current];
            }
            return ret;
        }
    }
}
