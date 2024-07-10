using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.访问者模式
{
    public class Manager : Staff
    {
        public int kpi;

        public string name;

        public Manager(int kpi, string name)
        {
            this.kpi = kpi;
            this.name = name;
        }

        public void accept(Visitor visitor)
        {
            visitor.visit(this);
        }

        public int GetNewProductCount()
        {
            return this.kpi / 5;
        }
    }
}
