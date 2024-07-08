using DesignPattern23.工厂模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.桥接模式
{
    public abstract class Shape
    {
        protected DrawAPI drawAPI;

        public Shape(DrawAPI api)
        {
            drawAPI = api;
        }

        public abstract void draw();
    }
}
