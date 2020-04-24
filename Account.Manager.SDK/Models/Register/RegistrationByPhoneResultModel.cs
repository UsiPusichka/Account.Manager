using Account.Manager.SDK.Enums;
using Account.Manager.SDK.Models.Auth;

namespace Account.Manager.SDK.Models.Register
{
    public class RegistrationByPhoneResultModel : AuthTokenModel
    {
        /// <summary>
        /// Result of sending SMS.
        /// </summary>
        public AuthRegistrationCodeResult Code { get; set; }
    }
}
