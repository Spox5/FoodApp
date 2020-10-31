using Food.Data;
using Food.Data.Models;
using Food.Data.Repositories;
using Food.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MimeKit;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Food.Controllers
{
    public class UserController : Controller
    {
        private Configuration configuration;
        private readonly UserRepository userRepository;
        private const string securityKey = "gjknlfgdnjkl32423";
        private const int tokenExpirationTimeInMinutes = 1000;

        public UserController(UserRepository userRepository, Configuration configuration)
        {
            this.configuration = configuration;
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
        public ActionResult<UserViewModel> Login(string usernameOrEmail, string password)
        {
            User user;

            if (usernameOrEmail.Contains('@'))
                user = userRepository.GetByEmail(usernameOrEmail);
            else
                user = userRepository.GetByName(usernameOrEmail);


            if (user == null)
            {
                return new UserViewModel
                {
                    Success = false,
                    ErrorCode = 1
                };
            }

            if (usernameOrEmail.Length < 1)
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
                    Success = true,
                    Name = user.Name
                };
            }

            return new UserViewModel
            {
                Success = false,
                ErrorCode = 5
            };
        }


        [HttpPost]
        public int Register(string username, string password, string email)
        {
            var existingUserByEmail = userRepository.GetByEmail(email);
            var existingUserByName = userRepository.GetByName(username);

            if (existingUserByName != null)
            {
                return 1;
            }

            if (existingUserByEmail != null)
            {
                return 2;
            }

            if (password == null || password.Length < 5 || !password.Any(character => char.IsDigit(character)))
            {
                return 3;
            }

            if (username == null || !username.Any(character => char.IsLetter(character)))
            {
                return 4;
            }

            if (email == null)
            {
                return 5;
            }
            
            if (!IsValidEmail(email))
            {
                return 6;
            }

            (byte[] passwordHash, byte[] passwordSalt) = GetPasswordHashAndSalt(password);

            Guid g = Guid.NewGuid();

            var user = new User
            {
                Name = username,
                PasswordHash = passwordHash,
                IsActive = false,
                PasswordSalt = passwordSalt,
                guid = g,
                Email = email,
                RegisterAt = DateTime.UtcNow
            };

            userRepository.Add(user);
            var registeredUserId = userRepository.GetByName(user.Name).Id;

            MailController mail = new MailController(configuration);
            mail.SendEmailRegistration(g, username, email);

            return 0;
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPatch]
        public int ForgotPasswordSendNewPassword(string email)
        {

            if (string.IsNullOrEmpty(email))
                return 1;

            if (!IsValidEmail(email))
                return 2;

            var existingUserByEmail = userRepository.GetByEmail(email);

            if (existingUserByEmail == null)
                return 3;

            var newPassword = GenerateNewPassword();

            (byte[] passwordHash, byte[] passwordSalt) = GetPasswordHashAndSalt(newPassword);
            existingUserByEmail.PasswordSalt = passwordSalt;
            existingUserByEmail.PasswordHash = passwordHash;

            userRepository.Update(existingUserByEmail);

            MailController mail = new MailController(configuration);
            mail.SendEmailForgotPassword(email, newPassword);

            return 0;
        }


        public static bool IsValidEmail(string email)
        {
            if (new EmailAddressAttribute().IsValid(email))
                return true;

            return false;
        }

        private static string GenerateNewPassword()
        {
            char[] Punctuations = "!@#$%^&*()_-+=[{]};:>|./?".ToCharArray();

            using (var rng = RandomNumberGenerator.Create())
            {
                int length = 8;
                int numberOfNonAlphanumericCharacters = 1;

                var byteBuffer = new byte[length];

                rng.GetBytes(byteBuffer);

                var count = 0;
                var characterBuffer = new char[length];

                for (var iter = 0; iter < length; iter++)
                {
                    var i = byteBuffer[iter] % 87;

                    if (i < 10)
                        characterBuffer[iter] = (char)('0' + i);

                    else if (i < 36)
                        characterBuffer[iter] = (char)('A' + i - 10);

                    else if (i < 62)
                        characterBuffer[iter] = (char)('a' + i - 36);

                    else
                        characterBuffer[iter] = Punctuations[i - 62];
                        count++;
                }

                if (count >= numberOfNonAlphanumericCharacters)
                    return new string(characterBuffer);

                int j;
                var rand = new Random();

                for (j = 0; j < numberOfNonAlphanumericCharacters - count; j++)
                {
                    int k;
                    do
                    {
                        k = rand.Next(0, length);
                    }
                    while (!char.IsLetterOrDigit(characterBuffer[k]));

                    characterBuffer[k] = Punctuations[rand.Next(0, Punctuations.Length)];
                }

                return new string(characterBuffer);
            }
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

        [HttpGet]
        public bool ValidateEmail(string email)
        {
            return !userRepository.DoesUserExistByEmail(email);
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
