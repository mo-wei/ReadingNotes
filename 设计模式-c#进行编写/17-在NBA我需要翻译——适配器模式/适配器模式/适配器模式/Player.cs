using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式
{
    abstract class Player
    {
        protected string name;
        public Player(string name)
        {
            this.name = name;
        }
        public abstract void Attack();
        public abstract void Defense();
    }

    //前锋
    class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine("前锋 {0} 进攻", name);
        }

        public override void Defense()
        {
            Console.WriteLine("前锋 {0} 防守", name);
        }
    }
    class Center : Player
    {
        public Center(string name) : base(name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine("中锋 {0} 进攻", name);
        }

        public override void Defense()
        {
            Console.WriteLine("中锋 {0} 防守", name);
        }
    }
    class Guards : Player
    {
        public Guards(string name) : base(name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine("后卫 {0} 进攻", name);
        }

        public override void Defense()
        {
            Console.WriteLine("后卫 {0} 防守", name);
        }
    }

    //外籍中锋
    class ForeignCenter
    {
        private string name;
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 注意此处中文命名是为了举例
        /// </summary>
        public void 进攻()
        {
            Console.WriteLine("外籍中锋 {0} 进攻", name);
        }

        public void 防守()
        {
            Console.WriteLine("外籍中锋 {0} 防守", name);
        }
    }
    class Translator : Player
    {
        
        public Translator(string name) : base(name)
        {
            wjzf.Name = name;
        }
        private ForeignCenter wjzf = new ForeignCenter();

        public override void Attack()
        {
            wjzf.进攻();
        }

        public override void Defense()
        {
            wjzf.防守();
        }
    }
}
