using System.Collections.Generic;
namespace SistemaPadaria.Models
{
    public class Estoque
    {
        public Estoque(int id, float pesoTotal, int quantidade)
        {
            this.Id = id;
            this.PesoTotal = pesoTotal;
            this.Quantidade = quantidade;

        }
        public int Id { get; private set; }
        public float PesoTotal { get; private set; }
        public int Quantidade { get; private set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}