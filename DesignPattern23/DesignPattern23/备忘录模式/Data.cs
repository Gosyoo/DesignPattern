using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.备忘录模式
{
    public class Data
    {
        public string status;

        public int handle;

        public string name;



        public static Data Copy(Data data)
        {
            Data d = new Data();
            d.status = data.status;
            d.handle = data.handle;
            d.name = data.name;
            return d;
        }
    }
}
