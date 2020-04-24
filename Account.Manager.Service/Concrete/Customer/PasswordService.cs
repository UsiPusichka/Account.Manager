using Account.Manager.Repository.Abstract;
using Account.Manager.SDK.Abstract.Customer;
using Account.Manager.SDK.Models.Password;
using Account.Manager.Service.Concrete.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Account.Manager.Service.Concrete.Customer
{
    public class PasswordService : BaseAuthService, IPasswordService
    {
        public PasswordService(ITokenRepository tokenRepository) : base(tokenRepository)
        {
        }

        public Task<bool?> PasswdConfirm(PasswdConfirmModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool?> PasswdForgot(PasswdForgotModel model)
        {
            throw new NotImplementedException();
        }
    }
}
