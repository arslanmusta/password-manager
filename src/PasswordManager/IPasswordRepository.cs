using System.Collections;
using System.Collections.Generic;

namespace PasswordManager
{
    public interface IPasswordRepository
    {
        public ICollection<Password> Passwords { get; set; }
    }
}