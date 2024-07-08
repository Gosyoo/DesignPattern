using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.工厂模式
{
    /// <summary>
    /// 圆形
    /// </summary>
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("This is Circle ");
        }
    }
}
