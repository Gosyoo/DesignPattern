using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.中介者模式
{
    public class User
    {
        public string name;

        public User(string name)
        {
            this.name = name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void sendMessage(string message)
        {
            ChatRoom.showMessage(this, message);
        }
    }
}
