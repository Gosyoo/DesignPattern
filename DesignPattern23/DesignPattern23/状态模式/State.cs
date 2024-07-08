using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.状态模式
{
    /// <summary>
    /// 状态接口
    /// </summary>
    public interface State
    {
        public void doAction(Context context);
    }
}
