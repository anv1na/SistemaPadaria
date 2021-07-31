using System.Collections.Generic;
using System;
namespace SistemaPadaria.Models
{
    public class Venda
    {
        public Venda(int id, float valorTotal, SmallDateTime data)
        {
            this.Id = id;
            this.ValorTotal = valorTotal;
            this.Data = data;

        }
        public int Id { get; private set; }
        public float ValorTotal { get; private set; }
        public SmallDateTime Data { get; private set; }
        public IEnumerable<ItemVenda> ItemVendas { get; set; }
    }
}