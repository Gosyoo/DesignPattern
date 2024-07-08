using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.建造者模式
{
    internal class Coke : ColdDrink
    {
        public override string Name { get; set; } = "可乐";
        public override Packing Packing { get; set; } = new Bottle();
        public override int Pirce { get; set; } = 4;
    }
}
