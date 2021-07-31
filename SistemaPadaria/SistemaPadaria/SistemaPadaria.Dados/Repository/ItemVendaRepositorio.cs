using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaPadaria.Dominio.Modelo;
using SistemaPadaria.API.DTO;
using System.Data.SqlClient;

namespace SistemaPadaria.Dados.Repositorio
{
    public class ItemVendaRepositorio : BaseRepositorio<ItemVenda>
    {
         public bool Incluir( decimal PrecoVenda, float Quantidade, Produto produto, Venda venda)
        {
            var itemvenda = new ItemVenda();
            itemvenda.Cadastrar(PrecoVenda, Quantidade, venda, produto);

            if (Existe(ItemVenda))
            {
                return false;
            }

            return base.Incluir(ItemVenda);
        }      

        public override List< ItemVenda> SelecionarTudo()
        {
            return base.SelecionarTudo().OrderBy(x => x. ItemVenda).ToList();
        }

        public Produto SelecionarPorId(int Id)
        {
            return contexto. ItemVenda.FirstOrDefault(x => x.Id == id);
        }

        public bool AtualizarItemVenda(int Id, decimal PrecoVenda, float Quantidade, int IdVenda, int IdProduto)
        {
            var ItemVenda = SelecionarPorId(id);            

            if (ExisteAlteracao(Id, PrecoVenda, Quantidade, IdVenda, IdProduto))
            {
                return false;
            }

            itemVenda.Alterar(PrecoVenda, Quantidade, IdVenda, IdProduto);

            if(base.Alterar(itemVenda))
            {
                return new ItemVendaRepositorio().Alterar(PrecoVenda, Quantidade, IdVenda, IdProduto);
            }

            return false;
        }

    }
}