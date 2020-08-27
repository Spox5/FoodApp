using Food.Data.Models;
using Food.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Controllers
{
     public class ManageMealsController : Controller    
     {
        private readonly MealRepository mealRepository;

        public ManageMealsController(MealRepository mealRepository)
        {
            this.mealRepository = mealRepository;
        }

        [HttpGet]
        public IActionResult Index(int userID)
        {
            var meals = mealRepository.GetByUserId(userID);

            //var meals = new List<Meal>
            //{
            //   new Meal{Name="Kanapka z masłem"},
            //   new Meal{Name="Płatki z mlekiem"},
            //};

            return View(meals);

        }
     }
}
