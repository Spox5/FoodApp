using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food.Data.Models;
using Food.Data.Repositories;
using Food.ViewModel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ManageIngredientsController : Controller
    {
        private readonly IngredientRepository ingredientRepository;
        public ManageIngredientsController(IngredientRepository ingredientRepository)
        {
            this.ingredientRepository = ingredientRepository;
        }
        public IActionResult Index()
        {
            var userId = int.Parse(HttpContext.User.Identity.Name);
            var ingredients = ingredientRepository.GetByUserIdAndAllGeneric(userId);

            return View(ingredients);
        }

        [HttpPost]
        public int AddIngredient([FromBody]Ingredient ingredient)
        {
            var existingIngredient = ingredientRepository.GetByName(ingredient.Name);
            
            if (existingIngredient != null)
            {
                return 1;
            }
            if (ingredient.Name == null || !ingredient.Name.Any(character => char.IsLetter(character)))
            {
                return 2;
            }

            ingredientRepository.Add(ingredient);

            return 0;
        }

        [HttpPatch]
        public void UpdateIngredient([FromBody]Ingredient ingredient)
        {
            ingredientRepository.Update(ingredient);
        }

        [HttpDelete]
        public void DeleteIngredient([FromBody] Ingredient ingredient)
        {
            ingredientRepository.Delete(ingredient);
        }

        [HttpGet]
        public List<Ingredient> GetIngredients(int userId)
        {
           return ingredientRepository.GetByUserId(userId);
        }
    }
}
