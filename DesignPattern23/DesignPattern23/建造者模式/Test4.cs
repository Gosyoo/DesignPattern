using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.建造者模式
{
    /// <summary>
    /// 
    /// 建造者模式
    /// 
    /// 
    /// 
    /// </summary>
    public class Test4
    {
        public static void Test()
        {
            Meal meal = MealBuilder.prepareVegMeal();
            meal.Pay();
            Meal meal2 = MealBuilder.prepareNonVegMeal();
            meal2.Pay();

        }
    }
}
