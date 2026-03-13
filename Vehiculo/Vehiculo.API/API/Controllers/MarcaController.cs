using Abstracciones.Interfaces.API;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase, IMarcaController
    {
        private readonly IMarcaFlujo _marcaFlujo;
        private readonly ILogger<MarcaController> _logger;

        public MarcaController(IMarcaFlujo marcaFlujo, ILogger<MarcaController> logger)
        {
            _marcaFlujo = marcaFlujo;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerMarcas()
        {
            var resultado = await _marcaFlujo.ObtenerMarcas();

            if (!resultado.Any())
                return NoContent();

            return Ok(resultado);
        }
    }
}