using Abstracciones.Interfaces.DA;
using Abstracciones.Modelos;
using Microsoft.Data.SqlClient;
using Dapper;

namespace DA
{
    public class MarcaDA : IMarcaDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public MarcaDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
        }

        public async Task<IEnumerable<Marca>> ObtenerMarcas()
        {
            string query = @"ObtenerMarcas";
            var resultado = await _sqlConnection.QueryAsync<Marca>(query);
            return resultado;
        }
    }
}