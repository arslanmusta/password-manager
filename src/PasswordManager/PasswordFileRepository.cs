﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PasswordManager
{
    public class PasswordFileRepository : IPasswordRepository
    {
        private readonly string _fileName;
        private readonly ICollection<Password> _passwords;
        private readonly IEncryptor _encryptor;
        private readonly string _masterPassword;

        public PasswordFileRepository(string fileName, IEncryptor encryptor, string masterPassword)
        {
            _fileName = fileName;
            _encryptor = encryptor;
            _masterPassword = masterPassword;
            
            using var stream = new FileStream(_fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using var readerStream = new StreamReader(stream, Encoding.UTF8);
            var encryptedJson = readerStream.ReadToEnd();
                
            var json = _encryptor.Decrypt(encryptedJson, _masterPassword);
            _passwords = string.IsNullOrEmpty(json) ? new List<Password>() : JsonSerializer.Deserialize<ICollection<Password>>(json);
            
        }

        public ICollection<Password> GetAll()
        {
            return _passwords;
        }

        public void Add(Password password)
        {
            _passwords.Add(password);
            
            Commit();
        }

        private void Commit()
        {
            var json = JsonSerializer.Serialize(_passwords);
            
            var encryptedJson = _encryptor.Encrypt(json, _masterPassword);
            
            using var stream = new FileStream(_fileName, FileMode.Truncate, FileAccess.Write);
            using var streamWriter = new StreamWriter(stream, Encoding.UTF8);
            streamWriter.Write(encryptedJson);
        }
    }
}