using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.建造者模式
{
    /// <summary>
    /// 餐厅
    /// </summary>
    public class MealBuilder
    {
        /// <summary>
        /// 准备素食餐
        /// </summary>
        /// <returns></returns>
        public static Meal prepareVegMeal()
        {
            Meal meal = new Meal();
            meal.Name = "素食餐";
            meal.addFood(new VegBurger());
            meal.addFood(new Coke());
            return meal;
        }

        /// <summary>
        /// 准备非素食餐
        /// </summary>
        /// <returns></returns>
        public static Meal prepareNonVegMeal()
        {
            Meal meal = new Meal();
            meal.Name = "非素食餐";
            meal.addFood(new ChickenBurger());
            meal.addFood(new Orange());
            return meal;
        }
    }
}
