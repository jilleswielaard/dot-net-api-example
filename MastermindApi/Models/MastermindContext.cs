using Microsoft.EntityFrameworkCore;

namespace MastermindApi.Models
{
    public class MastermindContext : DbContext
    {
        public MastermindContext(DbContextOptions<MastermindContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; } = null!;
    }
}
