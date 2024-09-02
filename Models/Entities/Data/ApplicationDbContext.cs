using Microsoft.EntityFrameworkCore;

namespace PayStackTesting.Models.Entities.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<PaymentRequest> PaymentRequests { get; set; }
    }
}
