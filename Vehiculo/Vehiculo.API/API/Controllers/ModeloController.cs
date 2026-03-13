using Abstracciones.Interfaces.API;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController : ControllerBase, IModeloController
    {
        private readonly IModeloFlujo _modeloFlujo;
        private readonly ILogger<ModeloController> _logger;

        public ModeloController(IModeloFlujo modeloFlujo, ILogger<ModeloController> logger)
        {
            _modeloFlujo = modeloFlujo;
            _logger = logger;
        }

        [HttpGet("{idMarca}")]
        public async Task<IActionResult> ObtenerModelosPorMarca([FromRoute] Guid idMarca)
        {
            var resultado = await _modeloFlujo.ObtenerModelosPorMarca(idMarca);

            if (!resultado.Any())
                return NoContent();

            return Ok(resultado);
        }
    }
}