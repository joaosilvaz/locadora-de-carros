using locadora_de_carros.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace locadora_de_carros.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CarroEntity> Carros { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
