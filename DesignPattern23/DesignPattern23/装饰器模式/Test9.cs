using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.装饰器模式
{
    public class Test9
    {

        /// <summary>
        /// 装饰器模式  强调对封装对象功能的扩展
        /// </summary>
        public static void Test()
        {

            Shape circle = new Circle();

            Shape redCircle = new RedShapeDecorator(new Circle());

            Shape redRectangle = new RedShapeDecorator(new Rectangle());
            Console.WriteLine("普通的圆圈");
            circle.draw();

            Console.WriteLine("\n红色的圆圈");
            redCircle.draw();

            Console.WriteLine("\n红色的矩形");
            redRectangle.draw();
        }
    }
}
