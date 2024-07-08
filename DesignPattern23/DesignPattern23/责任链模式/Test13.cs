using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.责任链模式
{
    public class Test13
    {
        public static void Test()
        {
            AbstractLogger logger0 = new ConsoleLogger(Level.CONSOLE);
            AbstractLogger logger1 = new InfoLogger(Level.INFO);
            AbstractLogger logger2 = new InfoLogger(Level.WARNING);
            AbstractLogger logger3 = new ErrorLogger(Level.ERROR);
            AbstractLogger logger4 = new ConsoleLogger(Level.CONSOLE);

            AbstractLogger[] abstractLoggers = { logger0, logger1, logger2, logger3, logger4 };

            AbstractLogger LoggerHead =  GetLoggerList(abstractLoggers);

            

            LoggerHead.MesLogger(Level.INFO, "符合该等级的责任链子项输出 INFO");
            LoggerHead.MesLogger(Level.WARNING, "符合该等级的责任链子项输出 WARNING");
            LoggerHead.MesLogger(Level.CONSOLE, "符合该等级的责任链子项输出 CONSOLE");
            LoggerHead.MesLogger(Level.ERROR, "符合该等级的责任链子项输出 ERROR");

        }

        public static AbstractLogger GetLoggerList(AbstractLogger[] abstractLoggers, int index = 0)
        {
            AbstractLogger logger = abstractLoggers[index];
            if (index + 1 < abstractLoggers.Length)
            {
                abstractLoggers[index + 1].SetNextLogger(logger);
                return GetLoggerList(abstractLoggers, index + 1);
            }
            else
            {
                return logger;
            }
        }
    }
}
