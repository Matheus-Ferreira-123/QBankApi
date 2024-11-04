using Microsoft.EntityFrameworkCore;
using QBankApi.Models;

namespace QBankApi.Data
{
public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Conta> Contas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:unibankserver.database.windows.net,1433;Initial Catalog=UniBank;Persist Security Info=False;User ID=adminUniBank;Password=adminpass1@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}

