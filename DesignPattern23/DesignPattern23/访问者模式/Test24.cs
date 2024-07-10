using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.访问者模式
{
    public class Test24
    {
        public static void Test()
        {
            BusinessReport business = new BusinessReport();

            CEOVisitor visitor = new CEOVisitor();

            CTOVisitor visitor2 = new CTOVisitor();

            Console.WriteLine("============ CEO报表 =============");
            business.showReport(visitor);
            Console.WriteLine("============ CTO报表 =============");
            business.showReport(visitor2);


        }
    }
}
