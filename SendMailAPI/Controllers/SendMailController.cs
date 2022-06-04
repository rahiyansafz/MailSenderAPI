using Microsoft.AspNetCore.Mvc;

namespace SendMailAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SendMailController : ControllerBase
{
    private readonly IEmailService _emailService;
    public SendMailController(IEmailService emailService)
    {
        _emailService = emailService;
    }
    [HttpPost]
    public IActionResult SendEmail(EmailDto request)
    {
        _emailService.SendEmail(request);
        return Ok();
    }
}
