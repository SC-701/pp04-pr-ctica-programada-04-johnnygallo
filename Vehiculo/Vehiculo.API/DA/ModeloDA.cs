using Abstracciones.Interfaces.DA;
using Abstracciones.Modelos;
using Microsoft.Data.SqlClient;
using Dapper;

namespace DA
{
    public class ModeloDA : IModeloDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public ModeloDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }

        public async Task<IEnumerable<Modelo>> ObtenerModelosPorMarca(Guid idMarca)
        {
            string query = @"ObtenerModelosPorMarca";

            var resultado = await _sqlConnection.QueryAsync<Modelo>(query, new
            {
                IdMarca = idMarca
            });

            return resultado;
        }
    }
}