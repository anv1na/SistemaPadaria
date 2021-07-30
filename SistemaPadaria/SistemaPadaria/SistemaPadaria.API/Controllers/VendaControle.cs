namespace SistemaPadaria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaControle : ControllerBase
    {
        private readonly VendaRepositorio _repo;      

        public VendaController()
        {
            _repo = new VendaRepositorio();
        }

        [HttpGet]
        public IEnumerable<Venda> Get()
        {
            return _repo.SelecionarTudo();
        }
        
        [HttpGet("{id}")]
        public Venda Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }
        
        [HttpPost]
        public void Post([FromBody] VendaDTO dto)
        {
            var venda = new Venda();
            Venda.Cadastrar(dto.ValorTotal, dto.Data, dto.ItemVendas);

            _repo.Incluir(venda);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.AlterarStatus(id);
        }
    }
}