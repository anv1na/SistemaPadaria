using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaPadaria.Dados.Map
{
    public class ItemReceitaMap
    {
        public void Configure(EntityTypeBuilder<ItemReceita> builder)
        {
            builder.ToTable("ItemReceita");
            builder.Property(x => x.Quantidade).HasColumnType("float(10,2)").IsRequired();
            builder.HasMany<Produto>(p => p.Produto)
                    .WithOne(s => s.ItemReceita)
                    .HasForeignKey(i => i.IdProduto);
            builder.HasMany<Receita>(p => p.Receita)
                    .WithOne(s => s.ItemReceita)
                    .HasForeignKey(i => i.IdReceita);
        }
    }
}