using FoodiApp.Models.Interfaces;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace FoodiApp.Models.Services
{
    public class EmailService : IEmail
    {
        private readonly IConfiguration _configuration;
        

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
            

        }
        public async Task SendEmailAsync(string email, string subject,string textMessage)
        {
            // Read apiKey from appsetting
            string apiKey = _configuration["SendGrid:Key"];
            var client = new SendGridClient(apiKey);
            SendGridMessage message = new SendGridMessage();

            string fromEmail = _configuration["SendGrid:DefaultFromEmailAddress"];
            message.SetFrom(fromEmail);
            message.AddTo(email);
            message.SetSubject(subject);
            message.AddContent(MimeType.Text, textMessage);

            await client.SendEmailAsync(message);


        }
    }
}
