using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式
{
    class RoleStateMemento
    {
        //生命力
        private int vit;
        public int Vitality
        {
            get { return vit; }
            set { vit = value; }
        }
        //攻击力
        private int atk;
        public int Attack
        {
            get { return atk; }
            set { atk = value; }
        }
        //防御力
        private int def;
        public int Defense
        {
            get { return def; }
            set { value = def; }
        }
        public RoleStateMemento(int vit, int atk, int def)
        {
            this.vit = vit;
            this.atk = atk;
            this.def = def;
        }
        
    }
}
