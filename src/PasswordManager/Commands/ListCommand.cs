using System;

namespace PasswordManager.Commands
{
    public class ListCommand : IFileCommand, IMasterPasswordCommand
    {
        public string FileName { get; set; }
        public string MasterPassword { get; set; }
        
        public void Execute()
        {
            var repository = new PasswordFileRepository( FileName, new AesEncryptor(), MasterPassword);
            var passwords = repository.GetAll();
            foreach (var password in passwords)
            {
                Console.WriteLine($"Domain: {password.Domain}, Password: {password.HashedPassword}");
            }
        }

    }
}