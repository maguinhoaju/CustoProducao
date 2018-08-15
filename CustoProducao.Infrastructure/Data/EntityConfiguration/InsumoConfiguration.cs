using System;
using System.Collections.Generic;
using System.Text;
using CustoProducao.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustoProducao.Infrastructure.Data.EntityConfiguration
{
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            builder.HasKey(t => t.IdInsumo);
            builder.ToTable("TB_INSUMO");

            builder.Property(t => t.IdInsumo).HasColumnName("ID_INSUMO").IsRequired();
            builder.Property(t => t.CdInsumo).HasColumnName("CD_INSUMO").IsRequired();
            builder.Property(t => t.DtInsumoCadastro).HasColumnName("DT_INSUMO_CADASTRO").IsRequired();
            builder.Property(t => t.NmInsumo).HasColumnName("NM_INSUMO").IsRequired();
            builder.Property(t => t.DsInsumo).HasColumnName("DS_INSUMO").IsRequired();
            builder.Property(t => t.VlInsumoNota).HasColumnName("VL_INSUMO_NOTA").IsRequired();
            builder.Property(t => t.VlInsumoFrete).HasColumnName("VL_INSUMO_FRETE").IsRequired();
        }
    }
}
