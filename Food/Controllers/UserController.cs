using Food.Data;
using Food.Data.Models;
using Food.Data.Repositories;
using Food.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection.PortableExecutable;
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

        
        public ActionResult ActivateAccount(string g)
        {
            Guid guid = Guid.Parse(g);

            var user = userRepository.GetByGuid(guid);

            if (user.guid == guid && user.IsActive == false)
            {
                user.IsActive = true;
                userRepository.Update(user);
                ViewData["message"] = "Twoje konto zostało aktywowane. Możesz teraz się zalogować.";
                return View(ViewData);
            }
            else if (user.IsActive == true)
            {
                ViewData["message"] = "To konto jest już aktywne.";
                return View(ViewData);
            }
            else
            {
                ViewData["message"] = "Nie masz uprawnień do aktywacji tego konta.";
                return View(ViewData);
            }
        }

        [HttpGet]
        public ActionResult<UserViewModel> Login(string username, string password)
        {
            var user = userRepository.GetByName(username);

            if (user == null)
            {
                return new UserViewModel
                {
                    Success = false,
                    ErrorCode = 1
                };
            }

            if (username.Length < 1)
            {
                return new UserViewModel
                {
                    Success = false,
                    ErrorCode = 2
                };
            }

            if (string.IsNullOrEmpty(password) || password.Length < 1)
            {
                return new UserViewModel
                {
                    Success = false,
                    ErrorCode = 3
                };
            }

            if (user.IsActive == false)
            {
                return new UserViewModel
                {
                    Success = false,
                    ErrorCode = 4
                };
            }

            var passwordHash = GetHash(password, user.PasswordSalt);

            if (user.PasswordHash.SequenceEqual(passwordHash))
            {
                var token = GetJwtToken(user.Id);

                Response.Cookies.Append("token", token, new Microsoft.AspNetCore.Http.CookieOptions
                {
                    Expires = new DateTimeOffset(DateTime.Now.AddMinutes(1000))
                });

                return new UserViewModel
                {
                    Id = user.Id,
                    Token = token,
                    Success = true
                };
            }

            return new UserViewModel
            {
                Success = false,
                ErrorCode = 5
            };
        }

        [HttpPost]
        public int Register(string username, string password)
        {
            var existingUser = userRepository.GetByName(username);
            if (existingUser != null)
            {
                return 1;
            }

            if (password == null || password.Length < 5 || !password.Any(character => char.IsDigit(character)))
            {
                return 2;
            }

            if (username == null || !username.Any(character => char.IsLetter(character)))
            {
                return 3;
            }

            (byte[] passwordHash, byte[] passwordSalt) = GetPasswordHashAndSalt(password);

            Guid g = Guid.NewGuid();

            var user = new User
            {
                Name = username,
                PasswordHash = passwordHash,
                IsActive = false,
                PasswordSalt = passwordSalt,
                guid = g
            };

            userRepository.Add(user);
            var registeredUserId = userRepository.GetByName(user.Name).Id;

            MailController mail = new MailController();
            mail.SendEmail(g);

            return 0;
        }



        [HttpGet]
        public ActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete("token");

            return Redirect($"/{nameof(UserController).Replace("Controller", "")}");
        }

        [HttpGet]
        public bool ValidateUsername(string username)
        {
            return !userRepository.DoesUserExist(username);
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
