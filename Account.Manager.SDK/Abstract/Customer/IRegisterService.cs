using Account.Manager.SDK.Models.Register;
using System.Threading.Tasks;

namespace Account.Manager.SDK.Abstract.Customer
{
    public interface IRegisterService
    {
        /// <summary>
        /// Register user by email.
        /// </summary>
        /// <param name="model">Registration by email model.</param>
        /// <returns>Registration by email result model</returns>
        Task<RegistrationByEmailResultModel> RegisterByEmail(RegistrationByEmailModel model);

        /// <summary>
        /// Confirm email registration.
        /// </summary>
        /// <param name="securityStamp">Security stamp</param>
        /// <returns>confirmed-true</returns>
        Task<bool> EmailRegistrationConfirm(string securityStamp);

        /// <summary>
        /// Register by phone.
        /// </summary>
        /// <param name="model">Data to registration</param>
        /// <returns>Result of registration plus token info</returns>
        Task<RegistrationByPhoneResultModel> RegisterByPhone(RegistrationByPhoneModel model);
    }
}
