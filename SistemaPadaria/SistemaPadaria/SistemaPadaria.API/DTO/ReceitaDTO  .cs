using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPadaria.API.DTO
{
    public class ReceitaDTO
    {
        public string nome { get; private set; }
        public int rendimento { get; private set; }

        public ProdutoDTO Produto {get; set;}
    }
}