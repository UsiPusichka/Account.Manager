namespace Account.Manager.Service.Inner.Abstract
{
    public interface IPasswordEncrypt
    {
        /// <summary>
        /// Encrypt MD5
        /// </summary>
        /// <param name="passInitial"></param>
        /// <returns></returns>
        string Encrypt(string passInitial);

        /// <summary>
        /// validate password (regExp)
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        bool ValidatePassword(string password);
    }
}
