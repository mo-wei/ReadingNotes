﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 原型模式
{
    class WorkExperience : ICloneable
    {
        public string TimeArea { get; set; }
        public string Company { get; set; }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
