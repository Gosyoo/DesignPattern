using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.命令模式
{
    public class SellOrder : Order
    {

        public Stock stock;
        public int money = 0;

        public SellOrder(Stock stock, int money)
        {
            this.stock = stock;
            this.money = money;
        }

        public void execute()
        {
            this.stock.sell(this.money);
        }

        public void undo()
        {
            stock.Money -= this.money;
            Console.WriteLine("撤回，Money=" + stock.Money);
        }
    }
}
