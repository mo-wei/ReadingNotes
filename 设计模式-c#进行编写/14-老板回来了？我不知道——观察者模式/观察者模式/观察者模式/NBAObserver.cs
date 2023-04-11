using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    class NBAObserver
    {
        private string name;
        private Subject sub;

        public NBAObserver(string name, Subject subject)
        {
            this.name = name;
            this.sub = subject;
        }
        public void CloseNBADirectSeeding()
        {
            Console.WriteLine("{0}  {1} 关闭NBA直播",sub.SubjectState, name);
        }
    }
}
