using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class IngredientRepo
    {
        List<List<Ingredients>> _listOfIngredients = new List<List<Ingredients>>();


        public void AddIngredients(Ingredients item)
        {
            _listOfIngredients.Add(item);
        }
        public List<Ingredients> GetIngredients()
        {
            return _listOfIngredients;
        }
    }
}
