using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式
{
    //角色状态管理器
    class RoleStateCareTake
    {
        private RoleStateMemento memento;
        public RoleStateMemento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
