using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.桥接模式
{
    public interface DrawAPI
    {
        public void DrawCircle(int radius, int x, int y);
    }
}
