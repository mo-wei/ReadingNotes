using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式
{
    class GeneralManager : Manager
    {
        public GeneralManager(string name): base(name)
        {

        }
        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假")
            {
                Console.WriteLine("{0}{1} 数量{2} 被批准", name, request.RequestContent, request.RequestNum); ;
            }
            else if(request.RequestType == "加薪" && request.RequestNum  <= 500)
            {
                Console.WriteLine("{0}{1} 数量{2} 被批准", name, request.RequestContent, request.RequestNum); ;
            }
            else if (request.RequestType == "加薪" && request.RequestNum > 500)
            {
                Console.WriteLine("{0}{1} 数量{2} 再说吧", name, request.RequestContent, request.RequestNum); ;
            }
        }
    }
}
