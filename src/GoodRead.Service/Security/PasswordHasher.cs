using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.Security
{
    public static class PasswordHasher
    {
        private const string _key = "fed9e0da-9169-41f2-9745-84790ddfabd9";
        public static (string Hash, string Salt) Hash(string password)
        {
            string salt = GenerateSalt();
            string hash = BCrypt.Net.BCrypt.HashPassword(salt + password + _key);
            return (Hash: hash, Salt: salt);
        }

        public static bool Verify(string password, string salt, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(salt + password + _key, hash);
        }

        public static string Hash(string password, string salt)
        {
            return BCrypt.Net.BCrypt.HashPassword(salt + password + _key);
        }

        private static string GenerateSalt()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
