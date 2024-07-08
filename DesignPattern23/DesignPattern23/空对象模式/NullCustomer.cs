using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.空对象模式
{
    public class NullCustomer : AbstractCustomer
    {
        public override string GetName()
        {
            return "Not Custromer Data";
        }

        public override bool isNull()
        {
            return true;
        }
    }
}
