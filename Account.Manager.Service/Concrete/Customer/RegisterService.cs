using Account.Manager.Repository.Abstract;
using Account.Manager.SDK.Abstract.Customer;
using Account.Manager.SDK.Models.Register;
using Account.Manager.Service.Concrete.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Account.Manager.Service.Concrete.Customer
{
    public class RegisterService : BaseAuthService, IRegisterService
    {
        public RegisterService(ITokenRepository tokenRepository) : base(tokenRepository)
        {
        }

        public Task<bool> EmailRegistrationConfirm(string securityStamp)
        {
            throw new NotImplementedException();
        }

        public Task<RegistrationByEmailResultModel> RegisterByEmail(RegistrationByEmailModel model)
        {
            throw new NotImplementedException();
        }

        public Task<RegistrationByPhoneResultModel> RegisterByPhone(RegistrationByPhoneModel model)
        {
            throw new NotImplementedException();
        }
    }
}
