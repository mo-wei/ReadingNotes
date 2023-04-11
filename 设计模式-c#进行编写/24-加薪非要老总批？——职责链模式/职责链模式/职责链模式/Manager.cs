using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式
{
    abstract class Manager
    {
        protected string name;

        protected Manager superior;

        public Manager(string name)
        {
            this.name = name;
        }

        public void SetSuperior(Manager superior)
        {
            this.superior = superior;
        }

        abstract public void RequestApplications(Request request);

    }
}
