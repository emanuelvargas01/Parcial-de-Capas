using System;
using System.Security.Cryptography;
using System.Text;

namespace Negocio
{
    public class VerificarHashService : IVerificarHashService
    {
        private readonly IHashService hashService;

        public VerificarHashService(IHashService hashService)
        {
            this.hashService = hashService;
        }

        public bool VerificarHash(string password, byte[] hashAlmacenado)
        {
            if (string.IsNullOrEmpty(password) || hashAlmacenado == null)
                return false;

            byte[] hashGenerado = hashService.GenerarHash(password);

            if (hashGenerado.Length != hashAlmacenado.Length)
                return false;

            int diferencia = 0;

            for (int i = 0; i < hashGenerado.Length; i++)
            {
                diferencia |= hashGenerado[i] ^ hashAlmacenado[i];
            }

            return diferencia == 0;
        }
    }
}