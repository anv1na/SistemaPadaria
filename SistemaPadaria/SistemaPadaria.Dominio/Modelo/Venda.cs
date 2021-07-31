using System.Collections.Generic;
using.System;
namespace SistemaPadaria.Modelo
{
    public class Venda
    {
        public Venda(int id, float valorTotal, SmallDateTime data)
        {
            this.Id = id;
            this.ValorTotal = valorTotal;
            this.Data = data;

        }
        public int Id { get;  set; }
        public float ValorTotal { get; private set; }
        public SmallDateTime Data { get;  set; }
        public IEnumerable<ItemVenda> ItemVendas { get; set; }
    }
}