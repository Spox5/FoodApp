using Food.Data.Models;
using Food.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ManageUserController : Controller
    {
        private readonly UserRepository userRepository;

        public ManageUserController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IActionResult Index()
        {
            var loggedUser = userRepository.GetById(int.Parse(HttpContext.User.Identity.Name));

            return View(loggedUser);
        }

        [HttpPatch]
        public void Update([FromBody] User user)
        {
            userRepository.Update(user);
        }
    }
}
