using System;
using System.Collections.Generic;
using System.Text;

namespace 解释器模式
{
    //演奏文本
    class PlayContext
    {
        private string context;

        public PlayContext()
        {
        }
        public PlayContext(string context)
        {
            this.context = context;
        }

        public string Context
        {
            get { return context; }
            set { context = value; }
        }
    }
}
