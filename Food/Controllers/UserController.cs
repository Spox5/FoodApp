using Food.Data.Models;
using Food.Data.Repositories;
using Food.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Food.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository userRepository;
        private const string securityKey = "gjknlfgdnjkl32423";
        private const int tokenExpirationTimeInMinutes = 1000;

        public UserController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult<UserViewModel> Login(string username, string password)
        {
            var user = userRepository.GetByName(username);

            if (user == null)
            {
                return NotFound();
            }

            var passwordHash = GetHash(password, user.PasswordSalt);

            if (user.PasswordHash.SequenceEqual(passwordHash))
            {
                return new UserViewModel
                {
                    Id = user.Id,
                    Token = GetJwtToken(user.Id)
                };
            }

            return NotFound();
        }

        [HttpPost]
        public void Register(string username, string password)
        {
            (byte[] passwordHash, byte[] passwordSalt) = GetPasswordHashAndSalt(password);

            var user = new User
            {
                Name = username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            userRepository.Add(user);
        }

        private byte[] GetHash(string password, byte[] salt)
        {
            using (var hmac = new HMACSHA512(salt))
            {
                var passwordByteArray = Encoding.UTF8.GetBytes(password);
                return hmac.ComputeHash(passwordByteArray);
            }
        }

        private (byte[], byte[]) GetPasswordHashAndSalt(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                return (hmac.ComputeHash(Encoding.UTF8.GetBytes(password)), hmac.Key);
            }
        }

        private string GetJwtToken(int userId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userId.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(tokenExpirationTimeInMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(securityKey)), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
