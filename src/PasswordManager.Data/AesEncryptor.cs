using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManager.Data
{
    public class AesEncryptor : IEncryptor
    {
        private readonly byte[] _salt = {0x49, 0xF2, 0x49, 0x76, 0x61, 0x6e, 0x20, 0x65, 0x64, 0x76, 0x65, 0x64, 0x76};
        private readonly int _iterationCount = 1000;
        public string Encrypt(string text, string password)
        {
            var textBytes = Encoding.UTF8.GetBytes(text);
            using var aes = Aes.Create();
            using var pdb = new Rfc2898DeriveBytes(password, _salt, _iterationCount);

            aes.Key = pdb.GetBytes(32);
            aes.IV = pdb.GetBytes(16);
            
            using var memoryStream = new MemoryStream();
            using var cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
            
            using var streamWriter = new StreamWriter(cryptoStream);
            streamWriter.Write(text);
            streamWriter.Close();
            
            return Convert.ToBase64String(memoryStream.ToArray());
        }

        public string Decrypt(string text, string password)
        {
            using var aes = Aes.Create();
            using var pdb = new Rfc2898DeriveBytes(password, _salt, _iterationCount);
            
            aes.Key = pdb.GetBytes(32);
            aes.IV = pdb.GetBytes(16);
            
            using var memoryStream = new MemoryStream(Convert.FromBase64String(text));
            using var cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
            using var streamReader = new StreamReader(cryptoStream);

            return streamReader.ReadToEnd();
        }
    }
}