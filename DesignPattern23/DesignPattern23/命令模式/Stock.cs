using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.命令模式
{
    public class Stock
    {
        public string Name { get; set; }

        public int Money { get; set; }

        public void buy(int money)
        {
            this.Money -= money;
            Console.WriteLine(Name + "--购买,剩余金额--" + Money + "￥");
        }

        public void sell(int money)
        {
            this.Money += money;
            Console.WriteLine(Name + "--卖出,剩余金额--" + Money + "￥");
        }
    }
}
