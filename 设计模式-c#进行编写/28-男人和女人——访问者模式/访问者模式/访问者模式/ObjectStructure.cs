using System;
using System.Collections.Generic;
using System.Text;

namespace 访问者模式
{
    class ObjectStructure
    {
        private IList<Person> people = new List<Person>();

        //增加
        public void Attach(Person person)
        {
            people.Add(person);
        }

        //移除
        public void Detach(Person person)
        {
            people.Remove(person);
        }

        public void Display(Action visitor)
        {
            foreach(Person e in people)
            {
                e.Accept(visitor);
            }
        }
    }
}
