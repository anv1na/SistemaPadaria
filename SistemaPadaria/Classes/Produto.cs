using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPadaria.Classes
{
    public class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public bool Tipo { get; set; }
        public float Peso { get; set; }
        public float PrecoUnitario { get; set; }
        public string UnidadeMedida { get; set; }
        public DateTime Validade { get; set; }
        public bool Ativo { get; set; }
        /*
        FK ReceitaId: int   
        FK ItemReceitaId: int
        */
        public Produto(int id, string nome, string marca, bool tipo, float peso, float precoUnitario, string unidadeMedida)
        {
            Id = id;
            Nome = nome;
            Marca = marca;
            Tipo = tipo;
            Peso = peso;
            PrecoUnitario = precoUnitario;
            UnidadeMedida = unidadeMedida;
        }
        public void Inserir()
        {

        }
        public void AlterarStatus(bool ativo)
        {
            Ativo = ativo;
        }
        public void Consultar()
        {

        }
        public void CalcularPrecoVenda(float precoUnitario, int quantidade)
        {
            float precoTotal = quantidade * precoUnitario;
        }

    }
}
