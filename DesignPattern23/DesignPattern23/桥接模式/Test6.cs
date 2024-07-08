using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.桥接模式
{
    /// <summary>
    /// 
    /// 桥接模式
    /// 
    /// 通过构建一个类作为 实现类的 属性 ，来实现两个类之间的解耦
    /// 
    /// </summary>
    public class Test6
    {
        public static void Test()
        {
            Shape Circle1 = new Circle(10, 1, 1, new RedCircle());
            Shape Circle2 = new Circle(20, 100, 100, new GreenCircle());

            Circle1.draw();
            Circle2.draw();
        }
    }
}
