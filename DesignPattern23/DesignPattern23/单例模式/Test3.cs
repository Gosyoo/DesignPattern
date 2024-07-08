using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.单例模式
{
    public class Test3
    {
        /// <summary>
        /// 
        /// 单例模式 
        /// 
        /// 当该类只有一个实例对象的时候使用，控制类创建实例的行为
        /// 
        /// </summary>
        public static void Test()
        {
            SingleObject single1 = SingleObject.Instance();
            Console.WriteLine(single1.value);
            single1.value = "我是懒汉式2";

            SingleObject single2 = SingleObject.Instance();
            Console.WriteLine(single2.value);


            SingleObject2 single3 = SingleObject2.Instance();
            Console.WriteLine(single3.value);
            single3.value = "我是饿汉式2";

            SingleObject2 single4 = SingleObject2.Instance();
            Console.WriteLine(single4.value);

        }
    }
}
