using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.桥接模式
{
    public class RedCircle : DrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("画一个红圈，半径为：" + radius + ",圆心为：" + x + "," + y);
        }
    }
}
