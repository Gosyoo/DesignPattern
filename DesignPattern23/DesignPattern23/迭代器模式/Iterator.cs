using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.迭代器模式
{
    public interface Iterator
    {
        public bool hasNext();

        public Object next();
    }
}
