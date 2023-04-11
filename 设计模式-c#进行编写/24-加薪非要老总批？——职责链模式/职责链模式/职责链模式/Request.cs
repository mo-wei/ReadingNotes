using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式
{
    class Request
    {
        public string RequestType { get; set; }
        public int RequestNum { get; set; }
        public string RequestContent { get; set; }          
    }
}
