using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.中介者模式
{
    public class ChatRoom
    {
        public static void showMessage(User user, string message)
        {
            string name = user.name;
            Console.WriteLine("用户" + name + ":\t" + message);
        }
    }
}
