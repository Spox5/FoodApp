using Food.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.ViewModel
{
    public class SearchMealViewModel
    {
        public List<Meal> Meals {get; set;}
        public List<Ingredient> Ingredients { get; set; }
    }
}
