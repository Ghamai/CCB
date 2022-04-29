using CCB.Models;
using Microsoft.EntityFrameworkCore;

namespace CCB.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Contractors> Contractors { get; set; }
        public DbSet<Renewals> Renewals { get; set; }
    }
}
