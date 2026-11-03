using Datos;
using Entidades;

namespace Negocio
{
    public class N_Usuario
    {
        private static IHashService hashService = new HashService();

        private static IVerificarHashService verificarHashService =
            new VerificarHashService(hashService);

        public static E_Usuario Login(
            string strUsuario,
            string strPassword)
        {
            E_Usuario usuario = D_Usuario.Login(strUsuario);

            if (usuario == null)
                return null;

            bool resultado = verificarHashService.VerificarHash(
                strPassword,
                usuario.HashPassword
            );

            if (!resultado)
                return null;

            usuario.HashPassword = null;

            return usuario;
        }
    }
}