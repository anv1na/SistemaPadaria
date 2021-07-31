using System.Collections.Generic;
using System;

namespace SistemaPadaria.Dominio.Models
{
    public class Venda : IEntity
    {
        public int Id { get; private set; }
        public decimal ValorTotal { get; private set; }
        public SmallDateTime Data { get; private set; }
        public List<ItemVenda> ItemVendas { get; set; }

        public void Cadastrar (int id, decimal valorTotal, SmallDateTime data)
        {
            this.Id = id;
            this.ValorTotal = 0;
            var dataAgora = DateTime.Now;
            this.Data = dataAgora;

        }

        public void AdicionarTotal(decimal valor)
        {
            if (valor > 0)
            {
                ValorTotal += valor;
            }
        }
    }
}