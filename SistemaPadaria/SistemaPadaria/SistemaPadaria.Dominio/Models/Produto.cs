using System.Collections.Generic;

namespace SistemaPadaria.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public decimal Peso { get; set; }
        public decimal PrecoUnitario { get; set; }
        public string UnidadeMedida { get; set; }
        public bool Ativo { get; set; }
        public Receita Receita { get; set; }
        public ItemReceita itemReceita { get; set; }
        public ItemVenda itemVenda { get; set; }
        public Estoque estoque { get; set; }
        public List<ItemVenda> ItemVendas { get; set; }

        public void Cadastrar(string nome, string marca, decimal precoUnitario, string unidadeMedida, decimal peso)
        {
            Nome = nome;
            Marca = marca;
            PrecoUnitario = precoUnitario;
            UnidadeMedida = unidadeMedida;
            Peso = peso;
        }

        public void Alterar(string nome, decimal peso, decimal precoUnitario)
        {
            Nome = string.IsNullOrEmpty(nome.Trim()) ? Nome : nome;
            Peso = (peso <= 0) ? Peso : peso;
            PrecoUnitario = (precoUnitario <= 0) ? PrecoUnitario : precoUnitario;
        }

        public void Excluir()
        {

        }

        //Quando o produto está sem estoque
        public void AlterarStatus(bool ativo)
        {
            Ativo = ativo;
        }


        public void CalcularPrecoVenda(float precoUnitario, int quantidade)
        {
            float precoTotal = quantidade * precoUnitario;
        }
    }
}