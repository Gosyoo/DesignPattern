using DesignPattern23.工厂模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.抽象工厂模式
{
    public abstract class AbstractFactory
    {
        public abstract Shape getShapeByType(string type);

        public abstract Color getColorByType(string type);

    }
}
