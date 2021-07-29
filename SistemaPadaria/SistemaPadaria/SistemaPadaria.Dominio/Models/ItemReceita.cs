namespace SistemaPadaria.Models
{
    public class ItemReceita
    {
        public ItemReceita(float quantidade, Produto produto, Receita receita)
        {
            this.Quantidade = quantidade;
            this.Produto = produto;
            this.Receita = receita;

        }
        public float Quantidade {get; private set; }
        public Produto Produto { get; set; }
        public Receita Receita { get; set; }
    }
}