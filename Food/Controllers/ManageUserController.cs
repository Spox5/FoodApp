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
using System.ComponentModel.DataAnnotations;

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

        public User GetUser(int userId)
        {
            return userRepository.GetById(userId);
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

        [HttpPatch]
        public int UpdateUserEmail(int id, string email)
        {
            var userToEdit = userRepository.GetById(id);
            var sameEmailExistingUser = userRepository.GetByEmail(email);

            if (email == null)
            {
                return 1;
            }

            if (email == userToEdit.Email)
            {
                return 2;
            }

            if (sameEmailExistingUser != null)
            {
                return 3;
            }

            userToEdit.Email = email;
            userRepository.Update(userToEdit);

            return 0;
        }

        public static bool IsValidEmail(string email)
        {
            if (new EmailAddressAttribute().IsValid(email))
                return true;

            return false;
        }

        [HttpPatch]
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
