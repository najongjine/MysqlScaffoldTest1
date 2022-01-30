using Microsoft.AspNetCore.Identity.UI.Services;

namespace MysqlScaffoldTest1.Utility; // 여긴 님 프로젝트 경로 맞추기


public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        return Task.CompletedTask;
    }
}