using Account.Manager.SDK.Models.Auth;
using Account.Manager.SDK.Models.Login;
using System.Threading.Tasks;

namespace Account.Manager.SDK.Abstract.Customer
{
    public interface ILoginService
    {
        /// <summary>
        /// Login by email.
        /// </summary>
        /// <param name="model">Data to login</param>
        /// <returns>Token data</returns>
        Task<AuthTokenDataModel> LoginByEmail(LoginByEmailModel model);

        /// <summary>
        /// Login by code (from sms or refresh token).
        /// </summary>
        /// <remarks>from sms or refresh token</remarks>
        /// <param name="model">Data to login</param>
        /// <returns>Token info</returns>
        Task<AuthTokenModel> LoginByCode(LoginByCodeModel model);
    }
}
