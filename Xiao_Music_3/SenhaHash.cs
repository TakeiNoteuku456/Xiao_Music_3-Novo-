using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Xiao_Music_3
{
    internal class SenhaHash
    {
        public static string CriarHash(string senha)
        {
            using (SHA256 sha256 = SHA256Managed.Create())
            {
                // Converta a senha em bytes
                byte[] bytes = Encoding.UTF8.GetBytes(senha);

                // Calcule o hash
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Converta o hash em uma string hexadecimal
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }

        public static bool VerificarHash(string senha, string hashArmazenado)
        {
            // Crie o hash da senha fornecida
            string hashSenha = CriarHash(senha);

            // Compare os hashes
            return string.Equals(hashSenha, hashArmazenado, StringComparison.OrdinalIgnoreCase);
        }
    }
}
