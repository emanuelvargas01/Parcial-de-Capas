
using Entidades;

namespace Negocio.Validadores
{
    public class ValidadorEntero : IValidador
    {
        public string MensajeError { get; private set; } = string.Empty;

        public bool EsValido(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor) ||
                !int.TryParse(valor, out int resultado) ||
                resultado < 0)
            {
                MensajeError = "Debe ingresar un numero entero valido";
                return false;
            }

            MensajeError = string.Empty;
            return true;
        }
    }
}
