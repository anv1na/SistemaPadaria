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
            itemvenda.Cadastrar(PrecoVenda, Quantidade, produto, venda);

            if (Existe(ItemVenda))
            {
                return false;
            }

            return base.Incluir(ItemVenda);
            ProdutoVendido(itemVenda.Produto, itemVenda.Quantidade);
            AdicionandoNoTotal(itemVenda.ValorUnitario, itemVenda.Quantidade, itemVenda);
            return true;
        }      

        public override List< ItemVenda> SelecionarTudo()
        {
            return base.SelecionarTudo().OrderBy(x => x. Produto.Nome).ToList();
        }

        public Produto SelecionarPorId(int Id)
        {
            return contexto. ItemVenda.FirstOrDefault(x => x.Id == id);
        }

        public bool ProdutoVendido(Produto produto, decimal quantidade)
        {
            var produtoNaLoja = new LojaRepositorio();
            produtoNaLoja.ProdutoVendido(produto, quantidade);
            return true;
        }
        
        public bool AdicionandoNoTotal(decimal valor, decimal quantidade, ItemVenda itemVenda)
        {
            var total = valor * quantidade;
            itemVenda.Venda.AdicionarTotal(total);
            return true;
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