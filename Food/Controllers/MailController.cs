using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MailKit.Net.Smtp;
using MimeKit;

namespace Food.Controllers
{
    public class MailController : Controller
    {
        private Configuration configuration;
        public MailController(Configuration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public void SendEmail(Guid g, string email)
        {
            

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Asystent jedzeniowy", "asystentjedzeniowy@mateuszmusiela.it"));
            message.To.Add(new MailboxAddress("", email));
            message.Subject = "Aktywacja konta w aplikacji Asystent Jedzeniowy";

            message.Body = new TextPart("plain")
            {

                Text = @"Witaj,

                Dziękujemy za zarejestrowanie się w aplikacji Asystent Jedzeniowy. Aby aktywować Twoje konto i móc się zalogować,
                kliknij proszę w poniższy link.

                https://localhost:5001/User/ActivateAccount?g=" + g

                
            };

            using (var client = new SmtpClient())
            {
                client.Connect(configuration.Server, 465, MailKit.Security.SecureSocketOptions.Auto);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("login", "password");

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
