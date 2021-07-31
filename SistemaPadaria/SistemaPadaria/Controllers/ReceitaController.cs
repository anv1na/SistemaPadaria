using Microsoft.AspNetCore.Mvc;
using SistemaPadaria.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPadaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitaController : ControllerBase
    {
        private readonly ReceitaRepositorio _repo;

        public ReceitaController()
        {
            _repo = new ReceitaRepositorio();
        }
        // GET: api/<Receita>
    /*    [HttpGet]
     public IEnumerable<ReceitaRepositorio> Get()
        {
           // return _repo.SelecionarTudo();
        }

        // POST api/<Receita>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Receita>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Receita>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        } */
    } 
}
