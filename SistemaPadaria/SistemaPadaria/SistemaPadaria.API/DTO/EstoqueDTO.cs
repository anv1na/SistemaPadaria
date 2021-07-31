using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPadaria.API.DTO
{
    public class EstoqueDTO
    {
        public decimal quantidadeTotal { get; set; }
        public decimal quantidadeMinima { get; set; }
        public float pesoTotal { get; set; }
        public int IdProduto { get; set; }
    }
}