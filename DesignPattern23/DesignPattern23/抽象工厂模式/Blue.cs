using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.抽象工厂模式
{
    public class Blue : Color
    {
        public void fill()
        {
            Console.WriteLine("填充蓝色");
        }
    }
}
