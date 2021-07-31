namespace SistemaPadaria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoControle : ControllerBase
    {
        private readonly ProdutoRepositorio _repo;      

        public ProdutoController()
        {
            _repo = new ProdutoRepositorio();
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return _repo.SelecionarTudo();
        }
        
        [HttpGet("{id}")]
        public Produto Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }
        
        [HttpGet("{nome}")]
        public Produto Get(string nome)
        {
            return _repo.SelecionarPorNome(nome);
        }


        [HttpPost]
        public void Post([FromBody] ProdutoDTO dto)
        {
            var produto = new Produto();
            produto.Cadastrar(dto.Nome, dto.Marca, dto.Peso, dto.PrecoUnitario, dto.UnidadeMedida, dto.Ativo);

            _repo.Incluir(produto);
        }

         [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProdutoDTO dto)
        {
            var produtoVenda = new Produto();
            produto.Alterar(dto.Nome, dto.Marca, dto.Peso, dto.PrecoUnitario, dto.UnidadeMedida, dto.Ativo);

            _repo.Alterar(produto);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.AlterarStatus(id);
        }
    }
}