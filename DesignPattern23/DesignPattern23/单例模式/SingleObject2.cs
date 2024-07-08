using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.单例模式
{
    /// <summary>
    /// 单例模式 饿汉式
    /// </summary>
    public class SingleObject2
    {

        private static SingleObject2 single = new SingleObject2();

        private SingleObject2() { }

        public static SingleObject2 Instance()
        {
            return single;
        }

        public string value = "单例饿汉式";

    }
}
