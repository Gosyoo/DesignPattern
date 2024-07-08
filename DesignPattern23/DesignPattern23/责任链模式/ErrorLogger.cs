using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.责任链模式
{
    public class ErrorLogger : AbstractLogger
    {

        public ErrorLogger(Level lv)
        {
            this.level = lv;
        }

        public override void Write(string message)
        {
            Console.WriteLine("Error::\t\t" + message);
        }
    }
}
