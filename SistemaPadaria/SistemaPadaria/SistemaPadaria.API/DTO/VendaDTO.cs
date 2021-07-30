namespace SistemaPadaria.API.DTO
{
    public class VendaDTO
    {
        public decimal ValorTotal { get; private set; }
        public SmallDateTime Data { get; private set; }
        public List<ItemVendaDTO> ItemVendas { get; set; }
    }
}