using System.Collections;
using System.Collections.Generic;

namespace PasswordManager
{
    public interface IPasswordRepository
    {
        ICollection<Password> GetAll();

        void Add(Password password);
    }
}