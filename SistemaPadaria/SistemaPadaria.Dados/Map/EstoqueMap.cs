using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaPadaria.Dominio;
using SistemaPadaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.Dados.Map
{
    class EstoqueMap : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("Estoque");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.QuantidadeMinima).HasColumnType("decima(20,5)").IsRequired();
            builder.Property(x => x.QuantidadeTotal).HasColumnType("decima(20,5)").IsRequired();
            builder.Property(x => x.TipoDeMedida).HasColumnType("int").IsRequired();
            builder.HasOne<Produto>(p => p.Produto).WithOne(d => d.Estoque).HasForeignKey<Estoque>(i => i.Id);
        }
    }
}
