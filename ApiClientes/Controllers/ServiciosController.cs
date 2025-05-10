using ApiClientes.Repositories;
using LibClassModels.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {

        private readonly ServiciosRepository repo = new ServiciosRepository();
        private readonly ClienteRepository clienteRepo = new ClienteRepository();
        [HttpGet]
        public IActionResult GetServicios()
        {
            var servicios = repo.ObtenerServicios();
            return Ok(servicios);
        }
        [HttpGet("{id}")]
        public IActionResult GetServicio(int id)
        {
            var servicio = repo.ObtenerServicioPorId(id);
            if (servicio == null)
            {
                return NotFound();
            }
            return Ok(servicio);
        }

        [HttpGet("TotalVentas/{idServicio}")]
        public IActionResult GetTotalVentasPorServicio(int idServicio)
        {
            var clientes = clienteRepo.ObtenerClientes();
            var total = clientes.Sum(c => c.ServiciosContratados.Where(s => s.Id == idServicio).Sum(s => s.Precio));
            return Ok(total);
        }
        [HttpPost]
        public IActionResult PostServicio([FromBody] Servicios servicio)
        {
            if (servicio == null)
            {
                return BadRequest();
            }
            repo.AgregarServicio(servicio);
            return CreatedAtAction(nameof(GetServicio), new { id = servicio.Id }, servicio);
        }
        [HttpPut]

        public IActionResult PutServicio(int id, [FromBody] Servicios servicio)
        {
            var servicioAmodificar = repo.ActualizarServicio(id,servicio);
            if (servicioAmodificar == null)
            {
                return NotFound();
            }
            return Ok(servicioAmodificar);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteServicio(int id)
        {
            var servicio = repo.ObtenerServicioPorId(id);
            if (servicio == null)
            {
                return NotFound();
            }
            repo.EliminarServicio(id);
            return NoContent();
        }
    }
}
