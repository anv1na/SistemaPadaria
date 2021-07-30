namespace SistemaPadaria.Models
{
    public class ItemVenda : IEntity
    {
        public int Id { get; private set; }
        public decimal PrecoVenda { get; private set; }
        public float Quantidade { get; private set; }
        public int IdVenda {get; set;}
        public Venda Venda { get; set; }
        public int IdProduto {get; set;}
        public Produto Produto { get; set; }

         public ItemVenda(int id, decimal precoVenda, float quantidade, Venda idVenda, Produto idProduto)
        {
            this.Id = id;
            this.PrecoVenda = precoVenda;
            this.Quantidade = quantidade;
            this.Venda = idVenda;
            this.Produto = idProduto;

        }
    }
}