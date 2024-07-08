using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.观察者模式
{
    public class Observe2 : Observe
    {
        public Subject Subject { get; set; }

        public Observe2(Subject subject)
        {
            this.Subject = subject;
            Subject.AddObserve(this);
        }

        public void update()
        {
            Console.WriteLine("观察者2==" + Subject.GetStatus());
        }
    }
}
