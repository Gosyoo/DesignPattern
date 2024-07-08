using DesignPattern23.工厂模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.抽象工厂模式
{
    /// <summary>
    /// 
    /// 抽象工厂
    /// 
    /// 创建一个工厂的抽象类  创建多个工厂 在通过工厂创建 复杂 对象
    /// 
    /// </summary>
    public class Test2
    {
        public static void Test()
        {
            Abs_ShapeFactory shapeFactory = new Abs_ShapeFactory();
            Shape circle = shapeFactory.getShapeByType("Circle");
            circle.draw();

            Abs_ColorFactory colorFactory = new Abs_ColorFactory();
            Color color = colorFactory.getColorByType("Red");
            color.fill();
        }
    }
}
