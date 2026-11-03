
namespace Entidades
{
    public interface IValidador
    {
        bool EsValido(string valor);
        string MensajeError { get; }
    }
}
