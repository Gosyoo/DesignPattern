using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.责任链模式
{
    public abstract class AbstractLogger
    {
        public Level level;

        public AbstractLogger next;

        public void SetNextLogger(AbstractLogger next)
        {
            this.next = next;
        }

        public void MesLogger(Level lv, string message)
        {

            if (this.level == lv)
            {
                //Console.WriteLine(this.level);
                this.Write(message);
            }
            if (this.next != null)
            {
                next.MesLogger(lv, message);
            }
        }

        public abstract void Write(string message);
    }

    public enum Level
    {
        CONSOLE = 1,
        INFO = 2,
        WARNING = 3,
        ERROR = 4,
    }
}
