using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.装饰器模式
{
    public abstract class ShapeDecorator : Shape
    {
        public Shape shape;
        public ShapeDecorator(Shape shape)
        {
            this.shape = shape;
        }

        public virtual void draw()
        {
            shape.draw();
        }
    }
}
