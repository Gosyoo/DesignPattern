using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.空对象模式
{
    public abstract class AbstractCustomer
    {
        public string Name;

        public abstract bool isNull();

        public abstract string GetName();
    }
}
