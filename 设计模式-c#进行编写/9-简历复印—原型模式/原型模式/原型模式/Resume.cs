using System;

namespace 原型模式
{
    class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkExperience workExperience = new WorkExperience();

        public Resume(string name)
        {
            this.name = name;
        }
        public Resume(WorkExperience workExperience)
        {
            this.workExperience = (WorkExperience)workExperience.Clone();//Clone方法调用私有函数，以便克隆“工作经历”的数据
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string timeArea, string company)
        {
            this.workExperience.TimeArea = timeArea;
            this.workExperience.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0}, {1}, {2}", name, sex, age);
            Console.WriteLine("工作经历: {0}, {1}", workExperience.TimeArea, workExperience.Company);
        }
        public object Clone()
        {
            Resume obj = new Resume(this.workExperience);
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;
        }
    }
}
