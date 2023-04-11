using System;

namespace 备忘录模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建角色并且初始化
            GameRole lixiaoyao = new GameRole();
            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            //储存角色信息、正经人打仙剑谁不存档啊
            RoleStateCareTake careTake = new RoleStateCareTake();
            careTake.Memento = lixiaoyao.SaveState();

            //玄霄一套秒
            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            lixiaoyao.RecoveryState(careTake.Memento);
            lixiaoyao.StateDisplay();

        }
    }
}
