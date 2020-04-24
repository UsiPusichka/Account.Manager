namespace Account.Manager.SDK.Models.Password
{
    /// <summary>
    /// Set new passwd by link in Email
    /// </summary>
    public class PasswdConfirmModel
    {
        /// <summary>
        /// Hash from Email
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// New passwd
        /// </summary>
        public string Passwd { get; set; }

    }
}
