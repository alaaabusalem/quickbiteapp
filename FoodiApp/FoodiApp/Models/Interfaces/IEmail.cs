namespace FoodiApp.Models.Interfaces
{
    public interface IEmail
    {
        Task SendEmailAsync(string email, string subject , string textMessage);
    }
}
