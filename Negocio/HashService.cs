using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class HashService : IHashService
    {
        public byte[] GenerarHash(string password)
        {
            if (string.IsNullOrEmpty(password)) {
                throw new ArgumentException(
                    "La contraseña no puede estar vacia.",
                    nameof(password));
                }
            using (SHA512 sha512 = SHA512.Create()) {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                return sha512.ComputeHash(passwordBytes);
            }
        }
    }
}
