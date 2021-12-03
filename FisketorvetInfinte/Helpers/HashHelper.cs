using System.Security.Cryptography;
using System.Text;


namespace FisketorvetInfinte.Helpers
{
    public static class HashHelper
    {
            public static byte[] GetHash(string input)
            {
                using (HashAlgorithm algorithm = SHA256.Create())
                    return algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            }

            public static string HashPassword(string password)
            {
                StringBuilder sb = new StringBuilder();
                foreach (byte b in GetHash(password))
                    sb.Append(b.ToString("X2"));

                return sb.ToString();
            }
    }
}
