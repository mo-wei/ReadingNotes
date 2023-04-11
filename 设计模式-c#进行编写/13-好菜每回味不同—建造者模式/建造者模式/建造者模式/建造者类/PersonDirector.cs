using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式.建造者类
{
    class PersonDirector
    {
        private PersonBuilder m_director;
        public PersonDirector(PersonBuilder personBuilder)
        {
            m_director = personBuilder;
        }

        public void CreatPerson()
        {
            m_director.Drawhead();
            m_director.DrawBody();
            m_director.DrawArmLeft();
            m_director.DrawArmRight();
            m_director.DrawLegLeft();
            m_director.DrawLegRight();
        }
    }
}
