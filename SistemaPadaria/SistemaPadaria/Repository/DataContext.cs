using System.Reflection.Emit;
namespace SistemaPadaria.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Estoque> Estoque {get; set;}
        public DbSet<ItemReceita> ItemReceita {get; set;}
        public DbSet<ItemVenda> ItemVenda {get;set;}
        public DbSet<Produto> Produto {get; set;}
        public Dbset<Receita> Receita {get; set;}
        public DbSet<Venda> Venda {get; set;}

        protected override void OnModelCreating(ModuleBuilder builder)
        {
            builder.Entity<Estoque>()
                .HasData(new List<Estoque>()
                {
                    new Estoque() {Id = 1, PesoTotal = 100, Quantidade = 15},
                    new Estoque() {Id = 2, PesoTotal = 100, Quantidade = 15},
                    new Estoque() {Id = 3, PesoTotal = 100, Quantidade = 15},
                    new Estoque() {Id = 4, PesoTotal = 100, Quantidade = 15},
                    new Estoque() {Id = 5, PesoTotal = 100, Quantidade = 15},
                    new Estoque() {Id = 6, PesoTotal = 100, Quantidade = 15},
                    new Estoque() {Id = 7, PesoTotal = 100, Quantidade = 15}
                });

                builder.Entity<ItemReceita >()
                .HasData(new List<ItemReceita>()
                {
                    new ItemReceita () { Quantidade = 3, Produto = 1, Receita = 1},
                    new ItemReceita () { Quantidade = 330, Produto = 4, Receita = 1},
                    new ItemReceita () { Quantidade = 165, Produto = 5, Receita = 1},
                    new ItemReceita () { Quantidade = 165, Produto = 6, Receita = 1},
                    new ItemReceita () { Quantidade = 18, Produto = 7, Receita = 1}
                });

                 builder.Entity<ItemVenda >()
                .HasData(new List<ItemVenda >()
                {
                    new ItemVenda () { Id = 1, PrecoVenda = 10, Quantidade = 1, Venda = 1, Produto = 8},
                    new ItemVenda () { Id = 2, PrecoVenda = 7.18, Quantidade = 2, Venda = 1, Produto = 3}
                });

                 builder.Entity<Produto >()
                .HasData(new List<Produto >()
                {
                    new Produto () { Id = 1, Nome = "Ovo", Marca = "Da Fazenda", Peso = 1, PrecoUnitario = 0.40, UnidadeMedida = "Unidade", Ativo = true, itemVenda = null, Estoque = 1, itemReceita = 1, Receita = 1},
                    new Produto () { Id = 2, Nome = "Óleo", Marca = "Soya", Peso = 900, PrecoUnitario = 7.67, UnidadeMedida = "Mili Litro (mL)", Ativo = true, itemVenda = null, Estoque = 2, itemReceita = 2, Receita = 1},
                    new Produto () { Id = 3, Nome = "Leite", Marca = "Elegê", Peso = 1000 , PrecoUnitario = 3.59, UnidadeMedida = "Mili Litro (mL)", Ativo = true, itemVenda = null, Estoque = 3, itemReceita = 3, Receita = 1},
                    new Produto () { Id = 4, Nome = "Farinha de Trigo", Marca = "Dona Benta", Peso = 1000 , PrecoUnitario = 3.79, UnidadeMedida = "grama (g)", Ativo = true, itemVenda = null, Estoque = 4, itemReceita = 4, Receita = 1},
                    new Produto () { Id = 5, Nome = "Açúcar", Marca = "União", Peso = 1000 , PrecoUnitario = 3.19, UnidadeMedida = "grama (g)", Ativo = true, itemVenda = null, Estoque = 5, itemReceita = 5, Receita = 1},
                    new Produto () { Id = 6, Nome = "Achocolatado", Marca = "Nescau", Peso = 900, PrecoUnitario = 12.25, UnidadeMedida = "grama (g)", Ativo = true, itemVenda = null, Estoque = 6, itemReceita = 6, Receita = 1},
                    new Produto () { Id = 7, Nome = "Fermento", Marca = "Royal", Peso = 100, PrecoUnitario = 3,69, UnidadeMedida = "grama (g)", Ativo = true, itemVenda = null, Estoque = 7, itemReceita = 7, Receita = 1},
                    new Produto () { Id = 8, Nome = "Bolo de Chocolate", Marca = "Propria", Peso = 500, PrecoUnitario = 10, UnidadeMedida = "Unidade", Ativo = true, itemVenda = null, Estoque = null, itemReceita = 1, Receita = 1}
                });

                 builder.Entity<Receita >()
                .HasData(new List<Receita >()
                {
                    new Receita () { Id = 1, Nome = "Bolo de Chocolate", Rendimento = 1, Produto = 8}
                });

                 builder.Entity<Venda >()
                .HasData(new List<Venda >()
                {
                    new Venda () { Id = 1 , ValorTotal = 17.18, Data = datatime.parse("2021-08-04 08:35")}
                });

        }
    }
}