using SendMailAPI.Models;

namespace SendMailAPI.Services;

public interface IEmailService
{
    void SendEmail(EmailDto request);

}
