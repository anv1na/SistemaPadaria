using System.Collections.Generic;
using System.Linq;
namespace SistemaPadaria.Models
{
    public class Estoque
    {
        public int Id { get; private set; }
        public float PesoTotal { get; private set; }
        public float Quantidade { get; private set; }
        public IEnumerable<Produto> Produtos { get; set; }

        public List<Estoque> listaEstoque { get; set; }
        
        public void Inserir(int id, float pesoTotal, int quantidade)
        {
            this.Id = id;
            this.PesoTotal = pesoTotal;
            this.Quantidade = quantidade;
        }

        public void SubtrairEstoque(float itemReceita)
        {
            Quantidade -= itemReceita;
        }

        public void conversãoMedida() 
        {

        }
        public Estoque ConsultarPorId(int id)
        {
            return listaEstoque.FirstOrDefault(x => x.Id == id);
        }
        public List<Estoque> ConsultarListaEstoque() 
        {
            return listaEstoque.OrderBy(x => x.Produtos).ToList();
        }
        public void editar(int quantidade, float pesoTotal, int id) 
        {
            Id = Id;
            Quantidade = (quantidade <= 0) ? Quantidade : quantidade;
            PesoTotal = (pesoTotal <= 0) ? PesoTotal : pesoTotal;
        }
        public void deletar() 
        {

        }
    }
}