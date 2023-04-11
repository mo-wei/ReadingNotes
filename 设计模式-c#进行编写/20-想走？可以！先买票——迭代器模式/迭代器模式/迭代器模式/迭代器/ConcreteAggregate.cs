using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式.迭代器
{
    class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();
        public override Iterator CreateIterator()
        {
            return new Concreteiterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
