using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.工厂模式
{
    /// <summary>
    /// 正方形
    /// </summary>
    public class Square: Shape
    {
        public void draw()
        {
            Console.WriteLine("This is Square");
        }
    }
}
