using Capstone.Models;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Services
{
    public class EmailService : IEmailService
    {
        private readonly string _mailServer;
        private readonly string _sender;
        private readonly string _mailPort;
        private readonly string _password;
        private readonly string _senderName; 
        public EmailService(IConfiguration configuration)
        {
            _mailServer = configuration.GetSection("EmailSettings").GetSection("MailServer").Value; 
            _sender = configuration.GetSection("EmailSettings").GetSection("Sender").Value;
            _mailPort = configuration.GetSection("EmailSettings").GetSection("MailPort").Value;
            _password = configuration.GetSection("EmailSettings").GetSection("Password").Value;
            _senderName = configuration.GetSection("EmailSettings").GetSection("SenderName").Value;

        }
        public async Task SendEmail(Email email)
        {
            try
            {
                var mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress(_senderName, _sender));
                mimeMessage.To.Add(new MailboxAddress(email.To));
                mimeMessage.Subject = email.Subject;
                mimeMessage.Body = new TextPart("html")
                {
                    Text = email.Message
                };
                using (var client = new SmtpClient())
                {
                    int port = Convert.ToInt32(_mailPort);
                    await client.ConnectAsync(_mailServer, port, true);
                    await client.AuthenticateAsync(_sender, _password);
                    await client.SendAsync(mimeMessage);
                    await client.DisconnectAsync(true); 
                }
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }
    }
}
