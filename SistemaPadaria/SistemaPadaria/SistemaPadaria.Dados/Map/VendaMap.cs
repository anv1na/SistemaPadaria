using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.Dados.Map
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
       public void Configure(EntityTypeBuilder<Vendas> builder)
        {
            builder.ToTable("Venda");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ValorTotal).HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(x => x.Data).HasColumnType("smalldatetime").IsRequired();//??
            builder.HasMany<ItemVenda>(p => p.ItemVendas)
                    .WithOne(s => s.Vendas)
                    .HasForeignKey(i => i.IdItemVenda);
        } 
    }
}