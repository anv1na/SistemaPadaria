using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPadaria.Classes
{
    public class Produto
    {
        public int IdProduto;
        public string NomeProduto;
        public string MarcaProduto;
        public bool Tipo; //Produtos para revenda || para utilização na fabricação 
        public float Peso;
        public decimal PreçoUnitario;
        public string UnidadeMedida;
        public DateTime Validade;
    }

}
