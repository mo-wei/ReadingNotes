using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式
{
    class GameRole
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
        //状态显示
        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态：");
            Console.WriteLine("体力：{0}",this.vit);
            Console.WriteLine("攻击力：{0}",this.atk);
            Console.WriteLine("防御力：{0}",this.def);
            Console.WriteLine("");
        }
        //获得初始状态
        public void GetInitState()
        {
            this.vit = 100;
            this.atk = 100;
            this.def = 100;
        }
        //战斗
        public void Fight()
        {
            this.vit = 0;
            this.atk = 0;
            this.def = 0;
        }

        //保存进度
        public RoleStateMemento SaveState()
        {
            return new RoleStateMemento(vit, atk, def);
        }
        //恢复状态
        public void RecoveryState(RoleStateMemento menmeto)
        {
            this.vit = menmeto.Vitality;
            this.atk = menmeto.Attack;
            this.def = menmeto.Defense;
        }

    }

}
