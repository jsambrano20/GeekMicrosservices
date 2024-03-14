using GeekShopping.Email.Model;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.Email.Model.Context
{
    public class MySqlContext : DbContext
    {
        //dotnet ef migrations add ***************
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) {}

        public DbSet<EmailLog> Emails { get; set; }
    }
}