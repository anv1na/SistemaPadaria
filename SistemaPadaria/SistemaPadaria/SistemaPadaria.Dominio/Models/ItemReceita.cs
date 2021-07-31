namespace SistemaPadaria.Models
{
    public class ItemReceita
    {
         public int Id { get; set; }
        public decimal Quantidade { get; set; }

        public int IdProduto { get; set; }
        public Produto produto { get; set; }

        public Receita receita { get; set; }
        public void Cadastrar(decimal quantidade)
        {
            Quantidade = quantidade;
        }

    }
}