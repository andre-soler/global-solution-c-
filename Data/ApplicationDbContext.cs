using Microsoft.EntityFrameworkCore;
using FutureOfWork.Api.Models;

namespace FutureOfWork.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}
