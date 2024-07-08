using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.装饰器模式
{
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("绘制一个矩形");
        }
    }
}
