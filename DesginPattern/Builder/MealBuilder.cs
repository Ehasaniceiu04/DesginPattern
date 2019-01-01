using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());
            return meal;
        }
        public Meal PrepareNonVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new NonVegBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }
    }
}
