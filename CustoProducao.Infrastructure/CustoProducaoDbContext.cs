using CustoProducao.Core.Entities;
using CustoProducao.Infrastructure.Data.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace CustoProducao.Infrastructure
{
    public partial class CustoProducaoDbContext : DbContext
    {
        public CustoProducaoDbContext()
        {
        }

        public CustoProducaoDbContext(DbContextOptions<CustoProducaoDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //DO NOTHING
        }

        public virtual DbSet<Insumo> Insumos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InsumoConfiguration());
        }
    }
}
