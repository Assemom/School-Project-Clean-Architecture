using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MimeKit;
using SchoolProject.Service.Abstracts;
using SchoolProject.Shared.Absractions;
namespace SchoolProject.Service.Implementation
{
    public class EmailService(IOptions<EmailBinding> _options) : IEmailService
    {
        private readonly EmailBinding _options = _options.Value;

        public async Task<Result> SendMassege(string Email, string Messege, string? reason)
        {
            try
            {
                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(_options.Host, _options.Port, SecureSocketOptions.StartTls);
                    client.Authenticate(_options.Mail, _options.Password);

                    var messageLink = $"<a href=\"{Messege}\">Click here to confirm your email</a>";

                    var bodybuilder = new BodyBuilder
                    {
                        HtmlBody = Messege,
                        TextBody = Messege
                    };

                    var message = new MimeMessage
                    {
                        Body = bodybuilder.ToMessageBody() 
                    };

                    message.From.Add(new MailboxAddress(_options.DisplayName, _options.Mail));
                    message.To.Add(new MailboxAddress("testing", Email));

                    message.Subject = reason==null?"No Submitted":reason;
                    await client.SendAsync(message);
                    client.Disconnect(true);  
                }
                return Result.Success();
            }
            catch (Exception ex) {
                Console.WriteLine($"Email error: {ex}");

                return Result.Failure(new Error("Email.SendError", ex.Message, StatusCodes.Status400BadRequest));
            }

        }
    }
}
