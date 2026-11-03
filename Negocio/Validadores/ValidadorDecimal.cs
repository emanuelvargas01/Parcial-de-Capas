
using Entidades;

namespace Negocio.Validadores
{
    public class ValidadorDecimal : IValidador
    {
        public string MensajeError { get; private set; } = string.Empty;

        public bool EsValido(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor) ||
                !decimal.TryParse(valor, out decimal resultado) ||
                resultado < 0)
            {
                MensajeError = "Debe ingresar un numero decimal valido";
                return false;
            }

            MensajeError = string.Empty;
            return true;
        }
    }
}
