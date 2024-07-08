using DesignPattern23.工厂模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.抽象工厂模式
{
    public class Abs_ColorFactory : AbstractFactory
    {
        public override Shape getShapeByType(string type)
        {
            return null;
        }

        public override Color getColorByType(string type)
        {

            if (type == "Red")
            {
                return new Red();
            }
            else if (type == "Blue")
            {
                return new Blue();
            }
            else
            {
                return null;
            }
        }
    }
}
