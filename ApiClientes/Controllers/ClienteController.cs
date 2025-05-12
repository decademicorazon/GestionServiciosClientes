using ApiClientes.Repositories;
using LibClassModels.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
       
        private readonly ClienteRepository repo = new ClienteRepository();


        [HttpGet]
        public IActionResult GetClientes()

        {
            var clientes = repo.ObtenerClientes();
            return Ok(clientes);

        }

        [HttpGet("{id}")]
        public IActionResult GetCliente(int id)
        {
            var cliente = repo.ObtenerClientePorId(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }
        [HttpPost]
        public IActionResult PostCliente([FromBody] ClienteRequestPost cliente)
        {
            if (cliente == null)
            {
                return BadRequest();
            }
            repo.AgregarCliente(cliente);
            return CreatedAtAction(nameof(GetCliente), new { id = cliente.id }, cliente);
        }

        [HttpPut]
        public IActionResult PutCliente(int id ,[FromBody] Cliente cliente)
        {
           

           var clienteAmodificar= repo.ActualizarCliente(id,cliente);
            if (clienteAmodificar == null)
            {
                return NotFound();
            }
            return Ok(clienteAmodificar);

        }

        [HttpPost("AgregarServicio")]
        public IActionResult PostServicio(int idCliente,[FromBody]int idServicio)
        {
            
            var cliente = repo.ContratarServicio(idCliente, idServicio);
            if (cliente == null)
            {
                return NotFound("Cliente o servicio no encontrado");
            }
            return Ok(cliente);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteCliente(int id)
        {
            var cliente = repo.ObtenerClientePorId(id);
            if (cliente == null)
            {
                return NotFound();
            }
            repo.EliminarCliente(id);
            return NoContent();
        }



    }
}
