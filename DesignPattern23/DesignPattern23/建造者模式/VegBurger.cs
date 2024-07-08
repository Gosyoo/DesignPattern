using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.建造者模式
{
    public class VegBurger : Burger
    {
        public override string Name { get; set; } = "素食汉堡";
        public override Packing Packing { get; set; } = new Wrapper();
        public override int Pirce { get; set; } = 10;
    }
}
