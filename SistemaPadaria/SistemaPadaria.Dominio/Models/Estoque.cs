using SistemaPadaria.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace SistemaPadaria.Models
{
    public class Estoque : IEntity
    {
        public int Id { get; private set; }
        public float PesoTotal { get; private set; }
        public decimal QuantidadeTotal { get; private set; }
        public decimal QuantidadeMinima { get; private set; }
        public IEnumerable<Produto> Produtos { get; set; }
        public Produto Produto { get; set; }

        public List<Estoque> listaEstoque { get; set; }


        public void Cadastrar(int id, float pesoTotal, decimal quantidadeTotal, decimal quantidadeMinima)
        {
            Id = id;
            PesoTotal = pesoTotal;
            QuantidadeTotal = quantidadeTotal;
            QuantidadeMinima = quantidadeMinima;
        }

        public void SubtrairEstoqueReceita(decimal quantidade)
        {
            QuantidadeTotal -= quantidade;            
        }

        public void Editar(decimal quantidadeTotal, decimal quantidadeMinima, float pesoTotal, int id) 
        {
            Id = Id;
            QuantidadeTotal = (quantidadeTotal <= 0) ? QuantidadeTotal : quantidadeTotal;
            QuantidadeMinima = (quantidadeMinima <= 0) ? QuantidadeMinima : quantidadeMinima;
            PesoTotal = (pesoTotal <= 0) ? PesoTotal : pesoTotal;
        }
        public void deletar() 
        {

        }
    }
}