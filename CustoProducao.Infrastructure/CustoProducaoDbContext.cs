using CustoProducao.Core;
using CustoProducao.Infrastructure.DAL.EntityConfiguration;
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

            //modelBuilder.Entity<Insumo>(entity =>
            //{
            //    entity.HasKey(e => e.IdInsumo);

            //    entity.ToTable("TB_INSUMO");

            //    entity.Property(e => e.IdInsumo)
            //        .HasColumnName("ID_INSUMO")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.DsInsumo)
            //        .IsRequired()
            //        .HasColumnName("DS_INSUMO")
            //        .HasMaxLength(1000)
            //        .IsUnicode(false);

            //    entity.Property(e => e.DtInsumoCadastro)
            //        .HasColumnName("DT_INSUMO_CADASTRO")
            //        .HasColumnType("datetime");

            //    entity.Property(e => e.NmInsumo)
            //        .IsRequired()
            //        .HasColumnName("NM_INSUMO")
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.VlInsumoFrete).HasColumnName("VL_INSUMO_FRETE");

            //    entity.Property(e => e.VlInsumoNota).HasColumnName("VL_INSUMO_NOTA");
            //});
        }
    }
}
