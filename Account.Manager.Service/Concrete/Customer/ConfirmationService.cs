using Account.Manager.Repository.Abstract;
using Account.Manager.SDK.Abstract.Customer;
using Account.Manager.SDK.Models.Confirmation;
using Account.Manager.Service.Concrete.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Account.Manager.Service.Concrete.Customer
{
    public class ConfirmationService : BaseAuthService, IConfirmationService
    {
        public ConfirmationService(ITokenRepository tokenRepository) : base(tokenRepository)
        {
        }

        public Task<bool?> EmailConfirmation(EmailConfirmationModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool?> EmailConfirmationResend(EmailConfirmationResendModel model)
        {
            throw new NotImplementedException();
        }

        public Task<EmailConfirmationResultModel> EmailConfirmationSend(EmailConfirmationSendModel model)
        {
            throw new NotImplementedException();
        }
    }
}
