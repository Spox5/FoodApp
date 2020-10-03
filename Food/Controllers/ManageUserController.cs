using Food.Data.Models;
using Food.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Food.Data;

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

        public void UpdateUsername(int id, string username)
        {
            var userToEdit = userRepository.GetById(id);
            userToEdit.Name = username;
            userRepository.Update(userToEdit);
        }

        public void UpdateUserPassword(int id, string password)
        {
            var userToEdit = userRepository.GetById(id);

            (byte[] passwordHash, byte[] passwordSalt) = GetPasswordHashAndSalt(password);

            userToEdit.PasswordSalt = passwordSalt;
            userToEdit.PasswordHash = passwordHash;

            userRepository.Update(userToEdit);

        }

        private (byte[], byte[]) GetPasswordHashAndSalt(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                return (hmac.ComputeHash(Encoding.UTF8.GetBytes(password)), hmac.Key);
            }
        }
    }
}
