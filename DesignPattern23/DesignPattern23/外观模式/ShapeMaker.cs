using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.外观模式
{
    public class ShapeMaker
    {
        public Circle circle;
        public Rectangle rectangle;
        public Square square;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void drawCircle()
        {
            circle.draw();
        }

        public void drawRectangle()
        {
            rectangle.draw();
        }

        public void drawSquare()
        {
            square.draw();
        }
    }
}
