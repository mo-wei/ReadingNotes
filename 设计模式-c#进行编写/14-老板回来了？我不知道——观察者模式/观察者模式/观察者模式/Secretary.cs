using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    /// <summary>
    /// 与BOSS类相似
    /// </summary>
    class Secretary : Subject
    {

        public string SubjectState { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
