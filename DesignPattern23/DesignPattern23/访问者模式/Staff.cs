using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.访问者模式
{
    /// <summary>
    /// 被访问者 接口
    /// </summary>
    public interface Staff
    {
        /// <summary>
        /// 提供 接受访问的方法
        /// </summary>
        public void accept(Visitor visitor);
    }
}
