using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.解释器模式
{
    /// <summary>
    /// 表达式接口
    /// </summary>
    public interface Expression
    {
        /// <summary>
        /// 解释
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public bool interpret(string context);
    }
}
