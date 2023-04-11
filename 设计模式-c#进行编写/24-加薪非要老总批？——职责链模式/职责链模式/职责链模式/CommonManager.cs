using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式
{
    class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {

        }
        public override void RequestApplications(Request request)
        {
            if(request.RequestType == "请假" && request.RequestNum <= 2)
            {
                Console.WriteLine("{0}{1} 数量{2} 被批准", name, request.RequestContent, request.RequestNum); ;
            }
            else
            {
                if(superior != null)
                {
                    superior.RequestApplications(request);
                }
            }
        }
    }
}
