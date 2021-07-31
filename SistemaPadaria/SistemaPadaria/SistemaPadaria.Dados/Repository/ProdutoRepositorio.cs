using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using SistemaPadaria.Dominio.Models;

namespace SistemaPadaria.Dados.Repository
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>
    {
        public bool Incluir(string Nome, string Marca, decimal Peso, decimal PrecoUnitario, string UnidadeMedida, bool Ativo)
        {

            var novoProduto = new Produto();
            novoProduto.Cadastrar( nome, marca, peso, precoUnitario, unidadeMedida, ativo);

            if (VerificarDuplicidade(novoProduto))
            {
                return false;
            }

            return base.Incluir(novoProduto);
        }

        public bool AtualizarProduto(string Nome, string Marca, decimal Peso, decimal PrecoUnitario, 
            string UnidadeMedida, bool Ativo)
        {
            var produto = SelecionarPorId(id);            

            if (ExisteAlteracao(nome, marca, peso, precoUnitario, unidadeMedida, ativo))
            {
                return false;
            }
        }

        public void AlterarStatus(int id)
        {
            var produto = SelecionarPorId(id);
            var status = produto.Ativo;
            produto.AlterarStatus(!status);

        }

         public override List< Produto> SelecionarTudo()
        {
            return base.SelecionarTudo().OrderBy(x => x. Produto).ToList();
        }

        public Produto SelecionarPorId(int id)
        {
            return contexto. Produto.FirstOrDefault(x => x.Id == id);
        }

        public List<Produto> SelecionarPorNome(string nome)
        {
            return contexto.Produto.Where(x => x.Nome.Trim().ToUpper() == nome.Trim().ToUpper()).ToList();
        }

        private bool VerificarDuplicidade(Produto produto)
        {
            return contexto.Produto.Any(x => x.Nome.Trim().ToLower() == nome.Trim().ToLower()
            && x.Marca.Trim().ToLower() == marca.Trim().ToLower()
            && x.Peso.Trim().ToLower() == peso.Trim().ToLower()
            && x.PrecoUnitario.Trim().ToLower() == precoUnitario.Trim().ToLower()
            && x.UnidadeMedida.Trim().ToLower() == unidadeMedida.Trim().ToLower()
            && x.Ativo.Trim().ToLower() == ativo.Trim().ToLower());
        }

        private bool ExisteAlteracao(string Nome, string Marca, decimal Peso, decimal PrecoUnitario, string UnidadeMedida, bool Ativo)
        {
           return contexto.Produto.Any(x => x.Nome.Trim().ToLower() == nome.Trim().ToLower()
            && x.Marca.Trim().ToLower() == marca.Trim().ToLower()
            && x.Peso.Trim().ToLower() == peso.Trim().ToLower()
            && x.PrecoUnitario.Trim().ToLower() == precoUnitario.Trim().ToLower()
            && x.UnidadeMedida.Trim().ToLower() == unidadeMedida.Trim().ToLower()
            && x.Ativo.Trim().ToLower() == ativo.Trim().ToLower());
        }

        
    }
}