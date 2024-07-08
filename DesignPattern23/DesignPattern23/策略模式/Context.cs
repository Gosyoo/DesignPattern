using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.策略模式
{
    public class Context
    {
        public Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public int Dooperation(int num1, int num2)
        {
            return strategy.doOperation(num1, num2);
        }
    }
}
