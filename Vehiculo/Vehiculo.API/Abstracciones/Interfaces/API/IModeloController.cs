using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Abstracciones.Interfaces.API
{
    public interface IModeloController
    {
        Task<IActionResult> ObtenerModelosPorMarca(Guid idMarca);
    }
}
