using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.解释器模式
{
    public class Context
    {
        public AndExpression expression;

        public Context(string[] city, string[] person)
        {
            TerminalExpression cityExp = new TerminalExpression(city);
            TerminalExpression personExp = new TerminalExpression(person);
            expression = new AndExpression(cityExp, personExp);
        }

        public void FreeCheck(string context)
        {
            Console.WriteLine($"您是{context}");
            bool isfree = expression.interpret(context);
            if (isfree)
            {
                Console.WriteLine("享受免费乘车的优惠");
            }
            else
            {
                Console.WriteLine("您不是免费人员，本次乘车扣费2元！");
            }
        }
    }
}
