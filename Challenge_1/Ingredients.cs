using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Ingredients
    {
        public string AddIngredient { get; set; }

        public Ingredients(string addIngredient)
        {
            AddIngredient = addIngredient;
        }
        public Ingredients()
        {

        }
    }
}
