using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.代理模式
{
    public class Test12
    {
        /// <summary>
        /// 代理模式 强调对封装对象的控制
        /// </summary>
        public static void Test()
        {
            Image image = new ProxyImage("test_image.png");
            image.display();

            Console.WriteLine("无加载显示---");
            image.display();

        }
    }
}
