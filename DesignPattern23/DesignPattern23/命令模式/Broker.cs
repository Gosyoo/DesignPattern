using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.命令模式
{
    public class Broker
    {
        public List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void UndoOrder()
        {
            Order order = orders.Last();
            order.undo();
            orders.Remove(order);
        }

        public void ExecuteOrder()
        {
            foreach (Order order in orders)
            {
                order.execute();
            }
        }
    }
}
