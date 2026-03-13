namespace Abstracciones.Interfaces.Reglas
{
    public interface IConfiguracion
    {
        public string ObetenerMetodo(string seccion, string nombre);
        public string ObtenerValor(string llave);
    }
}
