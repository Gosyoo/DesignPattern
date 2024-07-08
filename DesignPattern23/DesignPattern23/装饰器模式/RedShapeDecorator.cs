using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.装饰器模式
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape shape) : base(shape)
        {
        }

        public override void draw()
        {
            base.draw();
            this.SetColor();
        }

        public void SetColor()
        {
            Console.WriteLine("Color:Red");
        }
    }
}
