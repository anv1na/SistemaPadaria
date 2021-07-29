using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaPadaria.Dados.Map
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Marca).HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Peso).HasColumnType("float(10,2)").IsRequired();
            builder.Property(x => x.PrecoUnitario).HasColumnType("decimal(10,2)").IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
            builder.HasMany<ItemVenda>(p => p.ItemVenda)
                    .WithOne(s => s.Produto)
                    .HasForeignKey(i => i.IdProduto);
            builder.HasMany<Estoque>(p => p.Estoque)
                    .WithOne(s => s.Produto)
                    .HasForeignKey(i => i.IdProduto);
            builder.HasMany<ItemReceita>(p => p.ItemReceita)
                    .WithOne(s => s.Produto)
                    .HasForeignKey(i => i.IdProduto);
            builder.HasMany<Receita>(p => p.Receita)
                    .WithOne(s => s.Produto)
                    .HasForeignKey(i => i.IdProduto);
        }
    }
}