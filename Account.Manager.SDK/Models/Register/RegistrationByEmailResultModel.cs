using Account.Manager.SDK.Enums;
using Account.Manager.SDK.Models.Auth;

namespace Account.Manager.SDK.Models.Register
{
    public class RegistrationByEmailResultModel : AuthTokenModel
    {
        public AuthRegistrationCodeResult Code { get; set; }
    }
}
