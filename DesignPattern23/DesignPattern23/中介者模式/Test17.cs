using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.中介者模式
{
    public class Test17
    {
        public static void Test()
        {
            User user1 = new User("John");
            User user2 = new User("Bob");

            user1.sendMessage("Hello!");
            user2.sendMessage("Nice to meet you");
        }
    }
}
