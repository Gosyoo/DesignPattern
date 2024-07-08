using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.组合模式
{
    public class Test8
    {
        public static void Test()
        {
            Employee BOSS = new Employee("Boss", "老板", 50000);
            Employee CEO = new Employee("CEO", "总监", 30000);

            Employee L1 = new Employee("L1", "管理1", 10000);

            Employee E1 = new Employee("E1", "员工1", 8000);
            Employee E2 = new Employee("E2", "员工2", 8000);

            Employee L2 = new Employee("L2", "管理2", 10000);

            Employee E3 = new Employee("E3", "员工3", 8000);
            Employee E4 = new Employee("E4", "员工4", 8000);

            BOSS.Add(CEO);

            CEO.Add(L1);
            CEO.Add(L2);

            L1.Add(E1);
            L1.Add(E2);

            L2.Add(E3);
            L2.Add(E4);

            foreach (Employee e in CEO.employees)
            {
                Console.WriteLine(e);
                foreach (Employee e2 in e.employees)
                {
                    Console.WriteLine(e2);
                }
            }


        }
    }
}
