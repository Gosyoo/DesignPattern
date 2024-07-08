using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.工厂模式
{
    /// <summary>
    /// 长方形
    /// </summary>
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("This is Rectangle");
        }
    }
}
