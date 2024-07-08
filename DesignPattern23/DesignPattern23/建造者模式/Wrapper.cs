using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.建造者模式
{
    /// <summary>
    /// 包装袋
    /// </summary>
    public class Wrapper : Packing
    {
        public string Parking { get { return "袋装"; } }
    }
}
