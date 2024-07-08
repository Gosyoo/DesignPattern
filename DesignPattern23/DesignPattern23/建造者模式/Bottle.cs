using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.建造者模式
{
    /// <summary>
    /// 瓶装
    /// </summary>
    public class Bottle : Packing
    {
        public string Parking { get { return "瓶装"; } }
    }
}
