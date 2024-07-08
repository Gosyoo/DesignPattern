using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.状态模式
{
    public class Test20
    {
        public static void Test()
        {
            Context context = new Context();

            State state = new StartState();
            state.doAction(context);

            Console.WriteLine("Player state is " + context.State);

            State state1 = new StopState();
            state1.doAction(context);

            Console.WriteLine("Player state is " + context.State);
        }
    }
}
