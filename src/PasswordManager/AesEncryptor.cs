using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManager
{
    public class AesEncryptor : IEncryptor
    {
        public string Encrypt(string text, string password)
        {
            using var aes = Aes.Create();

            aes.Key = Encoding.UTF8.GetBytes(password);
            aes.IV = new byte[16];
            
            using var memoryStream = new MemoryStream();

            using var cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
            using var streamWriter = new StreamWriter(cryptoStream);

            streamWriter.Write(text);

            return Convert.ToBase64String(memoryStream.ToArray());
        }

        public string Decrypt(string text, string password)
        {
            using var aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(password);
            aes.IV = new byte[16];
            
            using var memoryStream = new MemoryStream(Convert.FromBase64String(text));
            using var cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
            using var streamReader = new StreamReader(cryptoStream);

            return streamReader.ReadToEnd();
        }
    }
}