using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 建造者模式.建造者类
{
    class PernsonThinBuilder : PersonBuilder
    {
        public PernsonThinBuilder(Graphics m_g, Pen m_p) : base(m_g, m_p) { }
        public override void DrawArmLeft()
        {
            m_g.DrawLine(m_p, 60, 50, 40, 100);//左手
        }

        public override void DrawArmRight()
        {
            m_g.DrawLine(m_p, 70, 50, 90, 100);//右手
        }

        public override void DrawBody()
        {
            m_g.DrawRectangle(m_p, 60, 50, 10, 50);//身体
        }

        public override void Drawhead()
        {
            m_g.DrawEllipse(m_p, 50, 20, 30, 30);//头
        }

        public override void DrawLegLeft()
        {
            m_g.DrawLine(m_p, 60, 100, 45, 150);//左脚
        }

        public override void DrawLegRight()
        {
            m_g.DrawLine(m_p, 70, 100, 85, 150);//右脚
        }
    }
}
