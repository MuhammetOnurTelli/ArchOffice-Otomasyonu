using System.Security.Cryptography;
using System.Text;

namespace ArchOffice
{
    public static class Sifreleme
    {
        public static string Hashle(string metin)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] baytlar = sha.ComputeHash(Encoding.UTF8.GetBytes(metin));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in baytlar) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}