using System.Collections.Generic;
namespace SistemaPadaria.Models
{
    public class ItemVenda
    {
        public ItemVenda(int id, decimal precoVenda, float quantidade, Venda venda, Produto produto)
        {
            this.Id = id;
            this.PrecoVenda = precoVenda;
            this.Quantidade = quantidade;
            this.Venda = venda;
            this.Produto = produto;

        }
        public int Id { get; private set; }
        public decimal PrecoVenda { get; private set; }
        public float Quantidade { get; private set; }
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
    }
}