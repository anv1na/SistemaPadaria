namespace SistemaPadaria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemVendaControle : ControllerBase
    {
        private readonly ItemVendaRepositorio _repo;      

        public VendaController()
        {
            _repo = new ItemVendaRepositorio();
        }

        [HttpGet]
        public IEnumerable<ItemVenda> Get()
        {
            return _repo.SelecionarTudo();
        }
        
        [HttpGet("{id}")]
        public ItemVenda Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }
        
        [HttpPost]
        public void Post([FromBody] ItemVendaDTO dto)
        {
            var venda = new Venda();
            Venda.Cadastrar(dto.PrecoVenda, dto.Quantidade, dto.Produto);

            _repo.Incluir(itemVenda);
        }

         [HttpPut("{id}")]
        public void Put(int id, [FromBody] ItemVendaDTO dto)
        {
            var itemVenda = new ItemVenda();
            itemVenda.Alterar(id, dto.PrecoVenda, dto.Quantidade, dto.Produto);

            _repo.Alterar(itemVenda);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.AlterarStatus(id);
        }
    }
}