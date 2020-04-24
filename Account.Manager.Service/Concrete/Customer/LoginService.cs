using Account.Manager.Repository.Abstract;
using Account.Manager.SDK.Abstract.Customer;
using Account.Manager.SDK.Models.Auth;
using Account.Manager.SDK.Models.Login;
using Account.Manager.Service.Concrete.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Account.Manager.Service.Concrete.Customer
{
    public class LoginService : BaseAuthService, ILoginService
    {
        public LoginService(ITokenRepository tokenRepository) : base(tokenRepository)
        {
        }

        public Task<AuthTokenModel> LoginByCode(LoginByCodeModel model)
        {
            throw new NotImplementedException();
        }

        public Task<AuthTokenDataModel> LoginByEmail(LoginByEmailModel model)
        {
            throw new NotImplementedException();
        }
    }
}
