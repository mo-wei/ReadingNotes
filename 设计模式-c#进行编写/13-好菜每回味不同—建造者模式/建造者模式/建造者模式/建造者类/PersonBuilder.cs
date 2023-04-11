using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 建造者模式.建造者类
{
    abstract class PersonBuilder
    {
        protected Graphics m_g;
        protected Pen m_p;

        public PersonBuilder(Graphics graphics, Pen pen)
        {
            m_g = graphics;
            m_p = pen;
        }

        public abstract void Drawhead();
        public abstract void DrawBody();
        public abstract void DrawArmLeft();
        public abstract void DrawArmRight();
        public abstract void DrawLegLeft();
        public abstract void DrawLegRight();

    }
}
