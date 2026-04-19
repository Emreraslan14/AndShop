using AndShop.Core.Dtos;

namespace AndShop.Services.Abstract
{
    public interface IMailService
    {
        void SendMail(ContactUsDto dto);
    }
}
