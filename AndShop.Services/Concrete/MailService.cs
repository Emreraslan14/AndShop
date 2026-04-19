using AndShop.Core.Dtos;
using AndShop.Services.Abstract;
using AndShop.Services.Settings;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace AndShop.Services.Concrete
{
    public class MailService : IMailService
    {
        private readonly MailSettings _settings;

        public MailService(IOptions<MailSettings> settings)
        {
            _settings = settings.Value;
        }

        public void SendMail(ContactUsDto dto)
        {
            try
            {
                using var mail = new MailMessage();
                using var client = new SmtpClient();

                mail.From = new MailAddress(_settings.FromEmail);
                mail.To.Add(_settings.ToEmail);
                mail.Subject = dto.Subject;
                mail.Body = "Mail : " + dto.Email + "<br/> Phone : " + dto.Phone + "<br/> Name : " + dto.Name + "<br/> Message : " + dto.Message;
                mail.IsBodyHtml = true;

                client.Host = _settings.Host;
                client.Port = _settings.Port;
                client.EnableSsl = false;
                client.Credentials = new NetworkCredential(_settings.Username, _settings.Password);

                client.Send(mail);
            }
            catch (Exception)
            {
            }
        }
    }
}
