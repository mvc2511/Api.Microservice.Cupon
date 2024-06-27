using Microsoft.EntityFrameworkCore;

namespace Api.Microservice.Cupon.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Api.Microservice.Cupon.Models.Cupon> Cupons { get; set; }
    }
}
