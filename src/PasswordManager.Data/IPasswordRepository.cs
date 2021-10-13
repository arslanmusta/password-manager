using System.Collections.Generic;

namespace PasswordManager.Data
{
    public interface IPasswordRepository
    {
        ICollection<Password> GetAll();

        void Add(Password password);

        void Remove(string domain);
    }
}