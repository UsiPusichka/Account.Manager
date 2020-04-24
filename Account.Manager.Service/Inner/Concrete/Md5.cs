using System.Security.Cryptography;
using System.Text;

namespace Account.Manager.Service.Inner.Concrete
{
    public class Md5
    {
        public static string Get(string value)
        {
            byte[] hash = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(value));
            StringBuilder stringBuilder = new StringBuilder();
            for (int index = 0; index < hash.Length; ++index)
                stringBuilder.Append(hash[index].ToString("x2"));
            return stringBuilder.ToString();
        }
    }
}
