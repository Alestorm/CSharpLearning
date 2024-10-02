using System.Security.Cryptography;
using System.Text;

namespace ContactsApi.Helpers
{
    public class Encrypt
    {
        public static string EncryptPassword(string password)
        {
            string hashedPassword = string.Empty;
            using (SHA512 sha512Hash = SHA512.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                hashedPassword = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            }
            return hashedPassword;
        }
    }
}
