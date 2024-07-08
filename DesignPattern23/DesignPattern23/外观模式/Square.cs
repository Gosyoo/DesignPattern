using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.外观模式
{
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("画一个正方形");
        }
    }
}
