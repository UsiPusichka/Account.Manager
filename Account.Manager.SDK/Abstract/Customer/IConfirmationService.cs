using Account.Manager.SDK.Models.Confirmation;
using System.Threading.Tasks;

namespace Account.Manager.SDK.Abstract.Customer
{
    public interface IConfirmationService
    {
        /// <summary>
        /// Confirm Email by code.
        /// </summary>
        /// <param name="model">Confirmation data.</param>
        /// <returns>void</returns>
        Task<bool?> EmailConfirmation(EmailConfirmationModel model);

        /// <summary>
        /// Send code on email for confirmation email.
        /// </summary>
        /// <param name="model">Data for send email.</param>
        /// <returns>[ToDo]Redirect uri</returns>
        Task<EmailConfirmationResultModel> EmailConfirmationSend(EmailConfirmationSendModel model);

        /// <summary>
        /// Send code on email for confirmation email again.
        /// </summary>
        /// <param name="model">Data for send email.</param>
        /// <returns>void</returns>
        Task<bool?> EmailConfirmationResend(EmailConfirmationResendModel model);
    }
}
