using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.建造者模式
{
    /// <summary>
    /// 餐食
    /// </summary>
    public class Meal
    {
        public string Name { get; set; } = "";
        public List<Food> Foods = new List<Food>();

        public void addFood(Food food)
        {
            Foods.Add(food);
        }

        public void Pay()
        {
            Console.WriteLine("===========" + Name + "============");
            for (int i = 0; i < Foods.Count; i++)
            {
                Food food = Foods[i];
                string name = food.Name;
                string packName = food.Packing.Parking;
                int pirce = food.Pirce;
                Console.WriteLine("你购买了一个  " + packName + "  的  " + name + "  ,花费了 " + pirce + " $");
            }
        }
    }
}
