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
    public class VendaRepositorio : BaseRepositorio<Venda>
    {
         public bool Incluir( decimal ValorTotal, SmallDateTime Data)
        {
            var venda = new Venda();
            venda.Cadastrar( ValorTotal, Data);

            if (Existe(venda))
            {
                return false;
            }

            return base.Incluir(venda);
        }      

        public override List<venda> SelecionarTudo()
        {
            return base.SelecionarTudo().OrderBy(x => x.Venda).ToList();
        }

        public Produto SelecionarPorId(int Id)
        {
            return contexto.Venda.FirstOrDefault(x => x.Id == id);
        }

    }
}