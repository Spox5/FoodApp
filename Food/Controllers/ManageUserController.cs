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

        [HttpPatch]
        public int UpdateUsername(int id, string username)
        {
            var userToEdit = userRepository.GetById(id);
            var sameNameExistingUser = userRepository.GetByName(username);

            if (username == null || !username.Any(character => char.IsLetter(character)))
            {
                return 1;
            }

            if (username == userToEdit.Name)
            {
                return 2;
            }

            if (sameNameExistingUser != null)
            {
                return 3;
            }

            userToEdit.Name = username;
            userRepository.Update(userToEdit);

            return 0;
        }

        public int UpdateUserPassword(int id, string password)
        {

            if (password == null || password.Length < 5 || !password.Any(character => char.IsDigit(character)))
            {
                return 1;
            }

            var userToEdit = userRepository.GetById(id);

            (byte[] passwordHash, byte[] passwordSalt) = GetPasswordHashAndSalt(password);

            userToEdit.PasswordSalt = passwordSalt;
            userToEdit.PasswordHash = passwordHash;

            userRepository.Update(userToEdit);

            return 0;

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
