using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    class Boss : Subject
    {
        public event EventHandler Update;

        private string action;

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }

        public void Notify()
        {
            Update();
        }
    }
}
