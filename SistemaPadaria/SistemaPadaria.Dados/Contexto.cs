using Microsoft.EntityFrameworkCore;
using SistemaPadaria.Dados.Repositorio;
using SistemaPadaria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.Dados
{
    class Contexto : DbContext
    {
        public DbSet<Receita> Receita { get; set; }

        public DbSet<ItemReceita> ItemReceita { get; set; }
    }
}
