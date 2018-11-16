using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class MenuContent
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public List<List<Ingredients>> NewIngredients { get; set; }

        public MenuContent(int mealNumber, string mealName, string description, List<Ingredients> newIngredients)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            NewIngredients = newIngredients;
        }
        public MenuContent()
        {

        }
    }
}
