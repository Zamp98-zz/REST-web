using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using REST_web.Models;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_web.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase {

        private readonly Cliente[] Clientes = new Models.Cliente[]{

                    new Cliente { ID = 1, Nome = "Eduardo Pires", Email = "falecom@eduardopires.net.br", Ativo = true },

                    new Cliente { ID = 2, Nome = "Bill Gates", Email = "gates@microsoft.com", Ativo = true },

                    new Cliente { ID = 3, Nome = "Aleister Crowley", Email = "aleister@therion.com", Ativo = false }
        };

        // GET: api/<ClienteController>
        [HttpGet]
        public Cliente[] Get() {
            return Clientes;
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id) {
            
            var clientes = Clientes;

            return clientes.SingleOrDefault(x=> x.ID == id);
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
