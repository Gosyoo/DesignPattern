using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.迭代器模式
{
    /// <summary>
    /// 容器 接口
    /// </summary>
    public interface Container
    {
        public Iterator GetIterator();
    }
}
