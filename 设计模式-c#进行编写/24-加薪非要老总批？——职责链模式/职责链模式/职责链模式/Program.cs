using System;

namespace 职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonManager commonManager = new CommonManager("经理");
            Majordomo majordomo = new Majordomo("总监");
            GeneralManager generalManager = new GeneralManager("总经理");

            commonManager.SetSuperior(majordomo);
            majordomo.SetSuperior(generalManager);


            Request request = new Request();
            request.RequestType = "请假";
            request.RequestContent = "小菜请假";
            request.RequestNum = 1;
            commonManager.RequestApplications(request);

            Request request2 = new Request();
            request2.RequestType = "请假";
            request2.RequestContent = "小菜请假";
            request2.RequestNum = 7;
            commonManager.RequestApplications(request2);

            Request request3 = new Request();
            request3.RequestType = "加薪";
            request3.RequestContent = "小菜请求加薪";
            request3.RequestNum = 500;
            commonManager.RequestApplications(request3);

            Request request4 = new Request();
            request4.RequestType = "加薪";
            request4.RequestContent = "小菜请求加薪";
            request4.RequestNum = 1000;
            commonManager.RequestApplications(request4);
        }
    }
}
