using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.桥接模式
{
    public class Circle : Shape
    {
        public int radius;
        public int x;
        public int y;


        public Circle(int radius, int x, int y, DrawAPI api) : base(api)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }

        public override void draw()
        {
            drawAPI.DrawCircle(radius, x, y);
        }
    }
}
