using Microsoft.AspNetCore.Identity;

namespace MysqlScaffoldTest1.Entity; // 프로젝트 이름과 경로에 맞게 수정

public class ApplicationUser : IdentityUser
{
    public String FirstName { get; set; }
    public String LastName { get; set; }
}