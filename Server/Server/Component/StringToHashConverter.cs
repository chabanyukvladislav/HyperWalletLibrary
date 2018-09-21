using System.Security.Cryptography;
using System.Text;

namespace Server.Component
{
    public class StringToHashConverter : IToHashConverter<string>
    {
        public string Content { get; set; }

        public string Convert()
        {
            if (Content == null) return null;
            byte[] data = Encoding.UTF8.GetBytes(Content);
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            byte[] dataSha256 = sha256.ComputeHash(data);
            string hash = Encoding.UTF8.GetString(dataSha256);
            return hash;
        }

        public StringToHashConverter(string content = null)
        {
            Content = content;
        }
    }
}
