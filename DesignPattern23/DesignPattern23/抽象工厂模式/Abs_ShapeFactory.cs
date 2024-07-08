using DesignPattern23.工厂模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.抽象工厂模式
{
    public class Abs_ShapeFactory : AbstractFactory
    {
        public override Shape getShapeByType(string type)
        {
            if (type == "Circle")
            {
                return new Circle();
            }
            else if (type == "Rectangle")
            {
                return new Rectangle();
            }
            else if (type == "Square")
            {
                return new Square();
            }
            else
            {
                return null;
            }
        }

        public override Color getColorByType(string type)
        {
            return null;
        }
    }
}
