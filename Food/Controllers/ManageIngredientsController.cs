using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers
{
    public class ManageIngredientsController : Controller
    {
        private readonly IngredientRepository ingredientRepository;
        public ManageIngredientsController(IngredientRepository ingredientRepository)
        {
            this.ingredientRepository = ingredientRepository;
        }
        public IActionResult Index(int userId)
        {
            var ingredients = ingredientRepository.GetByUserId(userId);

            return View(ingredients);
        }
    }
}
