using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.空对象模式
{
    public class Customer : AbstractCustomer
    {
        public Customer(string name)
        {
            this.Name = name;
        }
        public override string GetName()
        {
            return this.Name;
        }

        public override bool isNull()
        {
            return false;
        }
    }
}
