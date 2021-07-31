using SistemaPadaria.Dominio.Modelo;
using System.Collections.Generic;


namespace SistemaPadaria.Modelo
{
    public class Receita : IEntity
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Rendimento { get; set; }

        public int IdProduto { get; set; }
        public Produto Produto { get; set; }

        public List<ItemReceita> ItemReceita { get; set; }


        public void Alterar(string nome, int rendimento)
        {
            Nome = string.IsNullOrEmpty(nome.Trim()) ? Nome : nome;
            Rendimento = (rendimento <= 0) ? Rendimento : rendimento;
        }

        public void Cadastrar(string nome, int rendimento, int idproduto)
        {
            Nome = nome;
            Rendimento = rendimento;
            IdProduto = idproduto;
        }

    }
}