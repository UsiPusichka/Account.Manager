namespace Account.Manager.SDK.Models.Register
{
    /// <summary>
    /// Registration by email model.
    /// </summary>
    public class RegistrationByEmailModel
    {
        /// <summary>
        /// CompanyId.
        /// </summary>
        public long CompanyId { get; set; }

        /// <summary>
        /// Language.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Silent mode.
        /// </summary>
        public bool SilentMode { get; set; }
    }
}
