using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.命令模式
{
    public interface Order
    {
        public void execute();

        public void undo();
    }
}
