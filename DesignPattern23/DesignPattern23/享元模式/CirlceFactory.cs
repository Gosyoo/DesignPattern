using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.享元模式
{
    public class CirlceFactory
    {
        public static Dictionary<string, Circle> circleMap = new Dictionary<string, Circle>();

        public Circle GetCircle(string color)
        {

            if (!circleMap.TryGetValue(color, out var c))
            {
                circleMap.Add(color, new Circle(color));
            }
            return circleMap[color];
        }
    }
}
