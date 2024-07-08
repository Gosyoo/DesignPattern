using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.观察者模式
{
    /// <summary>
    /// 被观察的对象
    /// </summary>
    public class Subject
    {
        public List<Observe> observes = new List<Observe>();

        public int status;
        public void SetStatus(int status)
        {
            this.status = status;
            this.notifyAllObserves();
        }

        public int GetStatus()
        {
            return status;
        }

        public void AddObserve(Observe observe)
        {
            this.observes.Add(observe);
        }

        public void notifyAllObserves()
        {
            for (int i = 0; i < observes.Count; i++)
            {
                Observe observe = observes[i];
                observe.update();
            }
        }
    }
}
