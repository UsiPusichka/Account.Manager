using Account.Manager.Service.Inner.Abstract;
using System;
using System.Text.RegularExpressions;

namespace Account.Manager.Service.Inner.Concrete
{
    public class Md5PasswordEncrypt : IPasswordEncrypt
    {
        public string Encrypt(string passInitial)
        {
            if (string.IsNullOrEmpty(passInitial))
                throw new ArgumentException();

            return Md5.Get(passInitial);
        }

        public bool ValidatePassword(string password) =>
             new Regex(@"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z]{6,}").IsMatch(password);
    }
}
