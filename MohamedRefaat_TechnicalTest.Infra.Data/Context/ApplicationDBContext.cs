using Microsoft.EntityFrameworkCore;
using MohamedRefaat_TechnicalTest.Domain.Models;

namespace MohamedRefaat_TechnicalTest.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Appearance>  Appearances { get; set; }
       
        public DbSet<Biography>  Biographies { get; set; }
        public DbSet<Connections>  Connections { get; set; }
        public DbSet<Image>  Images { get; set; }
        public DbSet<PowerStats>  PowerStats { get; set; }
        public DbSet<Superhero>  Superheros { get; set; }

        public DbSet<Work>  Works { get; set; }

        

    }
}
