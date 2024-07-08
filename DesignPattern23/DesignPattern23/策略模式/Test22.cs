using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.策略模式
{
    public class Test22
    {
        public static void Test()
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine("10+5=" + context.Dooperation(10, 5));
            Context context1 = new Context(new OperationMul());
            Console.WriteLine("10*5=" + context1.Dooperation(10, 5));
            Context context2 = new Context(new OperationSub());
            Console.WriteLine("10-5=" + context2.Dooperation(10, 5));
        }
    }
}
