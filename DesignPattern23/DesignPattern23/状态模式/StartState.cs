using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.状态模式
{
    public class StartState : State
    {

        public void doAction(Context context)
        {
            context.State = this;
        }

        public override string ToString()
        {
            return "Start State";
        }
    }
}
