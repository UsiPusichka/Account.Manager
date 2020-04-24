using Account.Manager.SDK.Models.Password;
using System.Threading.Tasks;

namespace Account.Manager.SDK.Abstract.Customer
{
    public interface IPasswordService
    {
        /// <summary>
        /// Restore user password by Email.
        /// </summary>
        /// <remarks>Send email. User clicks by link in email and changes own password.</remarks>
        /// <returns>void</returns>
        Task<bool?> PasswdForgot(PasswdForgotModel model);

        /// <summary>
        /// Set user new passwd by link in Email from PasswdForgot method.
        /// </summary>
        /// <returns>void</returns>
        Task<bool?> PasswdConfirm(PasswdConfirmModel model);
    }
}
