using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.Flujo
{
    public interface IModeloFlujo
    {
        Task<IEnumerable<Modelo>> ObtenerModelosPorMarca(Guid idMarca);
    }
}
