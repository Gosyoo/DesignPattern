using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.备忘录模式
{
    public class Test18
    {
        public static void Test()
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker(originator);

            originator.setStatus("状态2");
            originator.setHandle(1);
            careTaker.Save();

            Console.WriteLine("改变状态1");
            Console.WriteLine(originator.ToString());


            originator.setStatus("状态3");
            originator.setHandle(2);
            careTaker.Save();

            Console.WriteLine("改变状态2");
            Console.WriteLine(originator.ToString());

            originator.setStatus("状态4");
            originator.setHandle(3);
            careTaker.Save();

            Console.WriteLine("改变状态3");
            Console.WriteLine(originator.ToString());

            careTaker.Load(0);
            Console.WriteLine("还原--状态1");
            Console.WriteLine(originator.ToString());

            careTaker.Load(1);
            Console.WriteLine("还原--状态2");
            Console.WriteLine(originator.ToString());

            careTaker.Load(2);
            Console.WriteLine("还原--状态3");
            Console.WriteLine(originator.ToString());
        }
    }
}
