using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaPadaria.Dados.Map
{
    public class ReceitaMap
    {
         public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Receita");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Rendimento).HasColumnType("int").IsRequired();
            builder.HasMany<Produto>(p => p.Produto)
                    .WithOne(s => s.Receita)
                    .HasForeignKey(i => i.IdProduto);
            builder.HasMany<ItemReceita>(p => p.ItemReceita)
                    .WithOne(s => s.Receita)
                    .HasForeignKey(i => i.IdReceita);
        }
    }
}