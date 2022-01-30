using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


using MysqlScaffoldTest1.Entity; // 이건 프로젝트 이름에 따라서 틀릴수 있으니 여기 빨간줄 뜨면 그냥 지우고

//DbSet<ApplicationUser> 에서 ctrl+enter 하고 using state문 자동완성 기능 사용.

namespace MysqlScaffoldTest1.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUser { get; set; }

}