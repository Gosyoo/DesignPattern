using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.责任链模式
{
    public class InfoLogger : AbstractLogger
    {
        public InfoLogger(Level lv)
        {
            this.level = lv;
        }

        public override void Write(string message)
        {
            Console.WriteLine("Info::\t\t" + message);
        }
    }
}
