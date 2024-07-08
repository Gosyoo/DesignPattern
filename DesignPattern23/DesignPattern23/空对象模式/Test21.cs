using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.空对象模式
{
    public class Test21
    {
        public static void Test()
        {
            CustomerFartory fartory = new CustomerFartory();

            List<AbstractCustomer> list = new List<AbstractCustomer>();

            list.Add(fartory.GetCustomer("客户4"));
            list.Add(fartory.GetCustomer("客户1"));
            list.Add(fartory.GetCustomer("客户5"));
            list.Add(fartory.GetCustomer("客户2"));
            list.Add(fartory.GetCustomer("客户3"));

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].GetName());
            }

        }
    }
}
