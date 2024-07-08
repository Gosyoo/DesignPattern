using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.建造者模式
{
    public class ChickenBurger : Burger
    {
        public override string Name { get; set; } = "鸡肉汉堡";
        public override Packing Packing { get; set; } = new Wrapper();
        public override int Pirce { get; set; } = 20;
    }
}
