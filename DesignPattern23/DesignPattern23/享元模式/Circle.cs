using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.享元模式
{
    public class Circle : Shape
    {
        string color;
        public string name;

        public Circle(string color)
        {
            this.color = color;
        }

        public void draw()
        {
            Console.WriteLine($"Circle\tColor:{this.color}\tName:{this.name}");
        }
    }
}
