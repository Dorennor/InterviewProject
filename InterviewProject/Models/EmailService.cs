using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace InterviewProject.Models
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Administrator", "vova.rud.00@gmail.com"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("in-v3.mailjet.com", 465, true);
                await client.AuthenticateAsync("2ab1257f482ab9c1424e3aa5f55d8395", "a9b3f6a8a73da7dbae2f2e5c95b48c60");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
