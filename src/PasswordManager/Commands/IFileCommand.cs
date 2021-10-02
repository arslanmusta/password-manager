namespace PasswordManager.Commands
{
    public interface IFileCommand : ICommand
    {
        string FileName { get; set; }
    }
}