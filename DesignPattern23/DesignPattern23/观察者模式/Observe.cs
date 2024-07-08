using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.观察者模式
{
    /// <summary>
    /// 观察者接口
    /// </summary>
    public interface Observe
    {
        public Subject Subject { get; set; }

        public abstract void update();
    }
}
