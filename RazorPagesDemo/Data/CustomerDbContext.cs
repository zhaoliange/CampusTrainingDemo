using Microsoft.EntityFrameworkCore;

namespace RazorPagesDemo.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesContacts.Models.Customer> Customer => Set<RazorPagesContacts.Models.Customer>();
    }
}
