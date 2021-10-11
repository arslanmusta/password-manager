using PasswordManager.Data;

namespace PasswordManager.Commands
{
    public class InsertCommand : IFileCommand, IMasterPasswordCommand, IPasswordCommand, IDomainCommand
    {
        public string FileName { get; set; }
        public string MasterPassword { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        
        public void Execute()
        {
            var repository = new PasswordFileRepository(FileName, new AesEncryptor(), MasterPassword);
            repository.Add(new Password
            {
                Domain = Domain,
                HashedPassword = Password
            });
        }
    }
}