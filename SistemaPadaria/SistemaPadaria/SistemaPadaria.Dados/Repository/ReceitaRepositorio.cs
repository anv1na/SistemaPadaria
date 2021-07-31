using Microsoft.EntityFrameworkCore;
using SistemaPadaria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.Dados.Repositorio
{
    class ReceitaRepositorio : BaseRepositorio<Receita>
    {
        public bool IncluirReceita(string nome, int rendimento, Produto produto)
        {

            var novaReceita = new Receita();
            novaReceita.Cadastrar(nome, rendimento, produto.Id);

            if (Existe(novaReceita))
            {
                return false;
            }
            return base.Incluir(novaReceita);
        }

        public bool AtualizarReceita(int id, string nome, int rendimento, Produto produto)
        {
            var receita = SelecionarPorId(id);

            if (!Existe(receita) || ExisteAlteracao(nome))
            {
                return false;
            }

            receita.Alterar(nome, rendimento);

            return base.Alterar(receita);
        }

        public bool Existe(Receita receita)
        {
            return contexto.Receita.Any(x => x.Nome.Trim().ToLower() == receita.Nome.Trim().ToLower());
        }

        public bool ExisteAlteracao(string nome)
        {
            return contexto.Receita.Any(x => x.Nome.ToUpper() == nome.Trim().ToUpper());
        }

        public List<Receita> SelecionarPorNome(string nome)
        {
            return contexto.Receita.Where(x => x.Nome.Trim().ToUpper() == nome.Trim().ToUpper()).ToList();
        }

        public override List<Receita> SelecionarTudo()
        {
            return base.SelecionarTudo().OrderBy(x => x.Nome).ToList();
        }

        public bool IncluirProduto(string nome, int rendimento, bool incluir, Produto produto)
        {
            var receita = SelecionarPorId(id);

            if (!Existe(receita) && incluir(false))
            {
                return false;
            }
            
            receita.quantidade += produto.peso;
            ItemReceita = new List<ItemReceita>(id);
            produto.peso -= ItemReceita.quantidade;

        }

    }
}