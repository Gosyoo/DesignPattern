using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.享元模式
{
    public class Test11
    {
        public static void Test()
        {
            CirlceFactory cirlceFactory = new CirlceFactory();

            Circle circle1 = cirlceFactory.GetCircle("red");
            circle1.draw();
            Circle circle2 = cirlceFactory.GetCircle("blue");
            circle2.draw();

            circle2.name = "蓝色的圆圈";
            Circle circle3 = cirlceFactory.GetCircle("blue");
            circle3.draw();

        }
    }
}
