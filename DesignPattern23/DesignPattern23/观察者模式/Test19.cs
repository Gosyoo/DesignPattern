using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.观察者模式
{
    public class Test19
    {
        public static void Test()
        {
            Subject subject = new Subject();

            Observe observe1 = new Observe1(subject);
            Observe observe2 = new Observe2(subject);
            Observe observe3 = new Observe3(subject);

            Console.WriteLine("第一次变化值：");
            subject.SetStatus(10);

            Console.WriteLine("第二次变化值：");
            subject.SetStatus(15);

            Console.WriteLine("第三次变化值：");
            subject.SetStatus(30);
        }
    }
}
