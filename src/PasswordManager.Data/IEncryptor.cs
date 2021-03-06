namespace PasswordManager.Data
{
    public interface IEncryptor
    {
        string Encrypt(string text, string password);
        string Decrypt(string text, string password);
    }
}