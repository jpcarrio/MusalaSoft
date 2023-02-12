using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class APIContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "DronsDb");
        }
        public DbSet<Drons> Drons { get; set; }
        public DbSet<Medications> Medicatrions { get; set; }
        
    }
}
