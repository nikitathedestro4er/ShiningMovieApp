using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

namespace EmailService
{
    public class SendingService
    {

        private GmailOptions _options;


        public SendingService()
        {
            _options = GetCredentials();
        }
        
        
        public void Send(Email email)
        {
            try
            {
                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(_options.Email, _options.Password);
                    MailMessage msgObj = new MailMessage();
                    msgObj.To.Add(email.Destination);
                    msgObj.From = new MailAddress(_options.Email);
                    msgObj.Subject = email.Subject;
                    msgObj.Body = email.Body;
                    client.Send(msgObj);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        private GmailOptions GetCredentials()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            var options = config.GetSection("gmail").Get<GmailOptions>();

            return options;
        }
    }
}