using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.建造者模式
{
    /// <summary>
    /// 汉堡
    /// </summary>
    public abstract class Burger : Food
    {
        public abstract string Name { get; set; }
        public abstract Packing Packing { get; set; }
        public abstract int Pirce { get; set; }
    }
}
