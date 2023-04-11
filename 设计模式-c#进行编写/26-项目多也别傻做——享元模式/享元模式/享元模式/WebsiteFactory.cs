using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 享元模式
{
    class WebsiteFactory
    {
        private Hashtable flyweights = new Hashtable();

        public Website GetWebsite(string key)
        {
            if(!flyweights.ContainsKey(key))
            {
                flyweights.Add(key, new ConcreteWebsite(key));
            }
            return (Website)flyweights[key];
        }

        public void GetWebsiteCount()
        {
            Console.WriteLine("网站数量为:" + flyweights.Count);
        }
    }
}
