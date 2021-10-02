namespace PasswordManager.Commands
{
    public interface IMasterPasswordCommand : ICommand
    {
        string MasterPassword { get; set; }
    }
}