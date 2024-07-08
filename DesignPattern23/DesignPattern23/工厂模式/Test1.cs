using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.工厂模式
{

    /// <summary>
    /// 工厂模式
    /// 通过一个工厂类创建 复杂 对象
    /// 
    /// </summary>
    public class Test1
    {
        public static void Test()
        {
            ShapeFactory factory = new ShapeFactory();
            Shape Circle = factory.getShapeByType("Circle");
            Circle.draw();

            Shape Rectangle = factory.getShapeByType("Rectangle");
            Rectangle.draw();

            Shape Square = factory.getShapeByType("Square");
            Square.draw();
        }

    }
}
