using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.建造者模式
{
    /// <summary>
    /// 食物
    /// </summary>
    public interface Food
    {
        public string Name { get; set; }

        public Packing Packing { get; set; }

        public int Pirce { get; set; }
    }
}
