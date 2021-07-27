namespace SistemaPadaria.Models
{
    public class Produto
    {
        public Produto(int id, string nome, string marca, float peso, float precoUnitario, string unidadeMedida, bool ativo, ItemVenda itemVenda, Estoque estoque, ItemReceita itemReceita, Receita receita)
        {
            this.Id = id;
            this.Nome = nome;
            this.Marca = marca;
            this.Peso = peso;
            this.PrecoUnitario = precoUnitario;
            this.UnidadeMedida = unidadeMedida;
            this.Ativo = ativo;
            this.itemVenda = itemVenda;
            this.Estoque = estoque;
            this.itemReceita = itemReceita;
            this.Receita = receita;

        }
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public float Peso { get; set; }
        public float PrecoUnitario { get; set; }
        public string UnidadeMedida { get; set; }
        public bool Ativo { get; set; }
        public ItemVenda itemVenda { get; set; }
        public Estoque Estoque { get; set; }
        public ItemReceita itemReceita { get; set; }
        public Receita Receita { get; set; }


        public void Inserir()
        {

        }
        public void AlterarStatus(bool ativo)
        {
            Ativo = ativo;
        }
        public void Consultar()
        {

        }
        public void CalcularPrecoVenda(float precoUnitario, int quantidade)
        {
            float precoTotal = quantidade * precoUnitario;
        }
    }
}