using Microsoft.EntityFrameworkCore;
using SistemaPadaria.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPadaria.Classes
{
    public class Contexto : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
   /*     public DbSet<Estoque> Estoque { get; set; }
        public DbSet<ItemReceita> ItemReceita { get; set; }
        public DbSet<Receita> Receita { get; set; }
        public DbSet<ItemVenda> ItemVenda { get; set; }
        public DbSet<Vendas> Vendas { get; set; }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-6OBPCCBR\SQLEXPRESS;Database=SistemaPadaria;Trusted_Connection=true");

            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());

            base.OnModelCreating(modelBuilder);


        }
    }
}
