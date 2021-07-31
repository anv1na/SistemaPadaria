using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaPadaria.Modelo;

namespace SistemaPadaria.Dados.Map
{
    class ReceitaMap : IEntityTypeConfiguration<Receita>
    {
        public void Configure(EntityTypeBuilder<Receita> builder)
        {
            throw new System.NotImplementedException(); builder.ToTable("Receita");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Rendimento).HasColumnType("int").IsRequired();
        }
    }
}
