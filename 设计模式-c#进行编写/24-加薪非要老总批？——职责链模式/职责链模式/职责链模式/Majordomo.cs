using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式
{
    class Majordomo : Manager
    {
        public Majordomo(string name) : base(name)
        {
        }
        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假" && request.RequestNum <= 5)
            {
                Console.WriteLine("{0}{1} 数量{2} 被批准", name, request.RequestContent, request.RequestNum); ;
            }
            else
            {
                if (superior != null)
                {
                    superior.RequestApplications(request);
                }
            }
        }
    }
}
