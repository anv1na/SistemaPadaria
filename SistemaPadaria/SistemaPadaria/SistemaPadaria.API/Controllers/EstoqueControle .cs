namespace SistemaPadaria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueControle : ControllerBase
    {
        private readonly EstoqueRepositorio _repo;      

        public VendaController()
        {
            _repo = new EstoqueRepositorio();
        }

        [HttpGet]
        public IEnumerable<Estoque> Get()
        {
            return _repo.ConsultarListaEstoque();
        }
        
        [HttpGet("{id}")]
        public EstoqueVenda Get(int id)
        {
            return _repo.ConsultarPorId(id);
        }
        
        [HttpPost]
        public void Post([FromBody] EstoqueDTO dto)
        {
            var estoque = new Estoque();
            estoque.Cadastrar(dto.quantidadeTotal, dto.quantidadeMinima, dto.pesoTotal, dto.IdProduto);

            _repo.Incluir(estoque);
        }

         [HttpPut("{id}")]
        public void Put(int id, [FromBody] EstoqueDTO dto)
        {
            var estoque = new Estoque();
            estoque.Alterar(dto.quantidadeTotal, dto.quantidadeMinima, dto.pesoTotal, dto.IdProduto);

            _repo.Alterar(estoque);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.AlterarStatus(id);
        }
    }
}