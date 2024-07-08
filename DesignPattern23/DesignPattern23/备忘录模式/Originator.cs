using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.备忘录模式
{
    /// <summary>
    /// 原型
    /// </summary>
    public class Originator
    {
        public Data data;

        public Originator()
        {
            Data d = new Data();
            d.status = "状态1";
            d.handle = 0;
            d.name = "Data";
            this.data = d;
        }

        public void setStatus(string status)
        {
            this.data.status = status;
        }

        public void setHandle(int handle)
        {
            this.data.handle = handle;
        }

        public void setName(string name)
        {
            this.data.name = name;
        }

        public Memento saveDataToMemento()
        {
            return new Memento(Data.Copy(data));
        }

        public void getDataToMemento(Memento memento)
        {
            this.data = memento.GetData();
        }

        public override string ToString()
        {
            return $"Name:{this.data.name}\tHandle:{this.data.handle}\tStatus:{this.data.status}";
        }
    }
}
