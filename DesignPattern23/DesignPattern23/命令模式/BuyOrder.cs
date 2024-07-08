using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.命令模式
{
    public class BuyOrder : Order
    {
        public Stock Stock;

        public int money = 0;

        public BuyOrder(Stock stock, int money)
        {
            Stock = stock;
            this.money = money;
        }

        public void execute()
        {
            Stock.buy(this.money);
        }

        public void undo()
        {
            Stock.Money += this.money;
            Console.WriteLine("撤回，Money=" + Stock.Money);
        }
    }
}
