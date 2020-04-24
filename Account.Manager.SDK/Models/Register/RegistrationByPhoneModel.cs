namespace Account.Manager.SDK.Models.Register
{
    public class RegistrationByPhoneModel
    {
        /// <summary>
        /// User phone number
        /// </summary>
        public long Phone { get; set; }

        /// <summary>
        /// Return token. Not send sms. Only in test mode.
        /// </summary>
        public bool SilentMode { get; set; }

        /// <summary>
        /// Company id
        /// </summary>
        public int CompanyId { get; set; }
    }
}
