namespace SistemaPadaria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitaControle : ControllerBase
    {
        private readonly ReceitaRepositorio _repo;      

        public VendaController()
        {
            _repo = new ReceitaRepositorio();
        }

        [HttpGet]
        public IEnumerable<Receita> Get()
        {
            return _repo.SelecionarTudo();
        }
        
        [HttpGet("{nome}")]
        public Receita Get(string nome)
        {
            return _repo.SelecionarPorNome(nome);
        }
        
        [HttpPost]
        public void Post([FromBody] ReceitaDTO dto)
        {
            var receita = new Receita();
            eceita.Cadastrar(dto.nome, dto.rendimento, dto.Produto);

            _repo.Incluir(receita);
        }

         [HttpPut("{id}")]
        public void Put(int id, [FromBody] ReceitaDTO dto)
        {
            var receita = new Receita();
            receita.Alterar(id, dto.PrecoVenda, dto.Quantidade, dto.Produto);

            _repo.Alterar(receita);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.AlterarStatus(id);
        }
    }
}