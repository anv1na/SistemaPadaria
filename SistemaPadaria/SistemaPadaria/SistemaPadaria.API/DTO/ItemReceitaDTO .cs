using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPadaria.API.DTO
{
    public class ItemReceitaDTO
    {
        public int Id { get; private set; }
        public decimal PrecoVenda { get; private set; }
        public float Quantidade { get; private set; }

        public ProdutoDTO Produto {get; set;}
    }
}