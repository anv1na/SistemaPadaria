using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.Dados.Map
{
    public class ItemVendaMap : IEntityTypeConfiguration<ItemVenda>
    {
        public void Configure(EntityTypeBuilder<ItemVendas> builder)
        {
            builder.ToTable("ItemVenda");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PrecoVenda).HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(x => x.Quantidade).HasColumnType("int").IsRequired();
        }
    }
}