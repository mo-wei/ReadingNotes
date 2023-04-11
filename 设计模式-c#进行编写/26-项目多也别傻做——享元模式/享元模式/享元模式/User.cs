using System;
using System.Collections.Generic;
using System.Text;

namespace 享元模式
{
    class User
    {
        private string name;

        public string Name
        {
            get { return name; }
        }

        public User(string name)
        {
            this.name = name;
        }
    }
}
