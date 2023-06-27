using matriz.Core.Application.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace matriz.Core.Application.Services;

public class HashSevice : IHashService
{
    public string ChaveValidacaoSeguranca(string key)
    {
        try
        {
            var builder = new StringBuilder();
            int count = 0;

            foreach (var k in key[..16])
            {
                builder.Append(k);
                if((++count % 4) == 0 && count < 16) builder.Append('-');
            }

            key = builder.ToString();

            return $"DD-{key}".ToUpper();
        }
        catch (Exception)
        {

            return string.Empty;
        }

    }

    public string HashSHA256(int key)
    {
		try
        {
            var inputBytes = Encoding.ASCII.GetBytes(key.ToString());
            var hash = SHA256.HashData(inputBytes);
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                stringBuilder.Append(hash[i].ToString("x2"));
            }

            return stringBuilder.ToString().ToUpper();
        }
        catch (Exception)
		{
			return string.Empty;
		}
    }
}
