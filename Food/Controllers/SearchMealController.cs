using Food.Data.Models;
using Food.Data.Repositories;
using Food.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Controllers
{
    public class SearchMealController : Controller
    {
        private readonly IngredientRepository ingredientRepository;

        public SearchMealController(IngredientRepository ingredientRepository)
        {
            this.ingredientRepository = ingredientRepository;
        }

        [HttpGet]
        public IActionResult Index(int userId)
        {
            var ingredients = ingredientRepository.GetByUserId(userId);

            //var ingredients = new List<Ingredient>
            //{
            //   new Ingredient{Name="Masło"},
            //   new Ingredient{Name="Chleb"},
            //   new Ingredient{Name="Płatki"},
            //   new Ingredient{Name="Mleko"}
            //};


            //var viewModel = new SearchMealViewModel();
            return View(userId);
        }
    }
}
