using Microsoft.Extensions.Configuration;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PR.Service.EmailSender
{
    public class EmailSender : IEmailService
    {
        private readonly IConfiguration _configuration;
        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string SendCodeToEmail(string userEmail)
        {
            string email = _configuration["Email"];
            string password = _configuration["MyKey"];
            string generatedCode = GenerateAuthCode();
            using (MailMessage message = new MailMessage(email, userEmail))
            {
                message.Subject = "Вход на сайт.";
                message.Body = "Ваш код для входа на сайт: " + generatedCode;
                using (SmtpClient client = new SmtpClient
                {
                    EnableSsl = true,
                    Host = "smtp.gmail.com",
                    Port = 587,
                    Credentials = new NetworkCredential(email, password),
                    UseDefaultCredentials = false
                })
                {
                    client.Send(message);
                }
            }
            return generatedCode;
        }

        string  GenerateAuthCode()
        {
            int length = 7;
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }
    }
}
