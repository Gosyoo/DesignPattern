using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.外观模式
{
    public class Test10
    {
        public static void Test()
        {
            ShapeMaker maker = new ShapeMaker();

            maker.drawSquare();
            maker.drawRectangle();  
            maker.drawCircle();
        }
    }
}
