using CCB.Models;
using Microsoft.EntityFrameworkCore;

namespace CCB.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Renewal> Renewals { get; set; }
    }
}
