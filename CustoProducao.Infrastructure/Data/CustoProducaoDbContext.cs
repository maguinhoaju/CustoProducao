using CustoProducao.Core.Entities;
using CustoProducao.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CustoProducao.Infrastructure.Data
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
        public virtual DbSet<Empresa> Empresas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new InsumoConfiguration());
        }
    }
}
