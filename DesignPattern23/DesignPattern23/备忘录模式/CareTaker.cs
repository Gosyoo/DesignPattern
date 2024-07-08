using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.备忘录模式
{
    /// <summary>
    /// 对原型 备忘录的 管理类
    /// </summary>
    public class CareTaker
    {
        public List<Memento> MementoLis = new List<Memento>();

        public Originator originator;

        public CareTaker(Originator originator)
        {
            this.originator = originator;
        }

        public void Save()
        {
            Memento memento = this.originator.saveDataToMemento();
            this.MementoLis.Add(memento);
        }

        public void Load(int index)
        {
            Memento memento = this.MementoLis[index];
            if (memento != null)
            {
                this.originator.getDataToMemento(memento);
            }
        }

    }
}
