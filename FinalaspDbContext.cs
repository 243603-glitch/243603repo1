using FInalasp.Models;
using Microsoft.EntityFrameworkCore;

namespace FInalasp
{
    public class FinalaspDbContext : DbContext
    {
        public FinalaspDbContext(DbContextOptions<FinalaspDbContext> option) : base(option)
        {
        }
        public DbSet<student> students { get; set; }

    }
}
