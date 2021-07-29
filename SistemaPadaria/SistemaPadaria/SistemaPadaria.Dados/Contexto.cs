using Microsoft.EntityFrameworkCore;

namespace SistemaPadaria.Dados
{
    public class Contexto : DbContext
    {
         public DbSet<Estoque> Estoque { get; set; }
        public DbSet<ItemReceita> ItemReceita { get; set; }
        public DbSet<ItemVenda> ItemVenda { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Receita> Receita { get; set; }
        public DbSet<Venda> Venda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ACNTB3RKLD53; Database=SistemaPadaria; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EstoqueMap());
            modelBuilder.ApplyConfiguration(new ItemReceitaMap());
            modelBuilder.ApplyConfiguration(new ItemVendaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new ReceitaMap());
            modelBuilder.ApplyConfiguration(new VendaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}