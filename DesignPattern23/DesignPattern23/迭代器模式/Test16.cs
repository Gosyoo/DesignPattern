using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.迭代器模式
{
    public class Test16
    {
        public static void Test()
        {
            NameRepository container = new NameRepository(["广州", "深圳", "东莞", "佛山"]);

            for (Iterator iterator = container.GetIterator(); iterator.hasNext();)
            {
                Console.WriteLine("城市：" + iterator.next());
            }
        }
    }
}
