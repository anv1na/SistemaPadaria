using SistemaPadaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.Dados.Repository
{
    class EstoqueRepository
    {
        private List<Estoque> listaEstoque { get; set; }
        public EstoqueRepository()
        {
            listaEstoque = new List<Estoque>();
        }
        public bool Inserir(float quantidadeTotal, decimal quantidadeMinima, float pesoTotal, Produto produto)
        {
            var inserirNoEstoque = new Estoque();
            inserirNoEstoque.Cadastrar(listaEstoque.Count + 1, quantidadeTotal, quantidadeMinima, produto);

            if (Existe(inserirNoEstoque))
            {
                return false;
            }
            listaEstoque.Add(inserirNoEstoque);

            return true;
        }

        private bool Existe(Estoque estoque)
        {
            return listaEstoque.Any(x => x.Produto == estoque.Produto);
        }

        public Estoque ConsultarPorId(int id)
        {
            return listaEstoque.FirstOrDefault(x => x.Id == id);
        }
        public List<Estoque> ConsultarListaEstoque()
        {
            return listaEstoque.OrderBy(x => x.Produtos).ToList();
        }
    }
}