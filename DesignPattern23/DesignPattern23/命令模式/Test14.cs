using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.命令模式
{
    public class Test14
    {
        public static void Test()
        {
            Stock stock = new Stock();

            stock.Name = "购买者  ";
            stock.Money = 100;

            Broker broker = new Broker();

            broker.AddOrder(new BuyOrder(stock, 10));
            broker.AddOrder(new BuyOrder(stock, 10));
            broker.AddOrder(new SellOrder(stock, 10));

            broker.AddOrder(new SellOrder(stock, 10));
            broker.AddOrder(new BuyOrder(stock, 10));


            broker.ExecuteOrder();

            broker.UndoOrder();
            broker.UndoOrder();
            broker.UndoOrder();

        }
    }
}
