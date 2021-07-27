using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaPadaria.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPadaria.Map
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Marca)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Peso)
                .HasColumnType("float(10,2)")
                .IsRequired();

            builder.Property(x => x.PrecoUnitario)
                .HasColumnType("float(10,2)")
                .IsRequired();

            builder.Property(x => x.UnidadeMedida)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Validade)
                .HasColumnType("smalldatetime")
                .IsRequired();
        }
    }
}
