using SistemaPadaria.Dominio.Modelo;
using System.Collections.Generic;


namespace SistemaPadaria.Modelo
{
    public class ItemReceita : IEntity
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