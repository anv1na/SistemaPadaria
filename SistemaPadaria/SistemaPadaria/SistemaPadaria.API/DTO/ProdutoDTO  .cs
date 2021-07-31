using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPadaria.API.DTO
{
    public class ProdutoDTO
    {
        public string Nome { get; private set; }
        public string Marca { get; private set; }
        public decimal Peso { get; private set; }
        public decimal PrecoUnitario { get; private set; }
        public string UnidadeMedida { get; private set; }
        public bool Ativo { get; private set; }

        
    }
}