using System.Collections.Generic;
namespace SistemaPadaria.Models
{
    public class Receita
    {
        public Receita(int id, string nome, int rendimento, Produto produto)
        {
            this.Id = id;
            this.Nome = nome;
            this.Rendimento = rendimento;
            this.Produto = produto;
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Rendimento { get; private set; }
        public Produto Produto { get; set; }

        public IEnumerable<ItemReceita> ItemReceitas { get; set; }
    }
}