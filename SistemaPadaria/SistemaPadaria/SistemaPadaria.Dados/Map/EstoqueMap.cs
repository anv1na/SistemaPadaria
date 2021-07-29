using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaPadaria.Dados.Map
{
    public class EstoqueMap : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("Estoque");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PesoTotal).HasColumnType("float").IsRequired();
            builder.Property(x => x.Quantidade).HasColumnType("int").IsRequired();
            builder.HasOne<Produto>(p => p.Produto)
                    .WithOne(d => d.Estoque)
                    .HasForeignKey<Estoque>(i => i.IdProduto);
        }
    }
}