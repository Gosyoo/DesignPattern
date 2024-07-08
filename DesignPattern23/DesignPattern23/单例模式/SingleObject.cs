using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.单例模式
{
    /// <summary>
    /// 单例模式 懒汉式
    /// </summary>
    public class SingleObject
    {
        private static SingleObject single;

        private SingleObject()
        {
        }

        public static SingleObject Instance()
        {
            if (single == null)
            {
                single = new SingleObject();
            }
            return single;
        }

        public string value = "单例懒汉式";
    }
}
