using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.备忘录模式
{
    public class Memento
    {
        public Data data;

        public Memento(Data data)
        {
            this.data = data;
        }

        public Data GetData()
        {
            return data;
        }

        public void SetData(Data data)
        {
            this.data = data;
        }
    }
}
