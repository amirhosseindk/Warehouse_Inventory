using Infrastructure.IServices;

namespace Infrastructure.Services
{
    public class PasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                var salt = hmac.Key;
                var hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(salt.Concat(hash).ToArray());
            }
        }

        public bool VerifyPassword(string hashedPassword, string providedPassword)
        {
            var decodedHashedPassword = Convert.FromBase64String(hashedPassword);
            var salt = decodedHashedPassword.Take(64).ToArray();
            var passwordHash = decodedHashedPassword.Skip(64).ToArray();

            using (var hmac = new System.Security.Cryptography.HMACSHA512(salt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(providedPassword));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }

}
