using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.空对象模式
{
    public class CustomerFartory
    {
        public List<string> list = new List<string>(["客户1", "客户2", "客户3"]);

        public AbstractCustomer GetCustomer(string name)
        {
            if (list.Contains(name))
            {
                return new Customer(name);
            }

            return new NullCustomer();
        }
    }
}
