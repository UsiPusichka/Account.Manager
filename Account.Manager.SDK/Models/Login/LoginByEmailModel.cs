namespace Account.Manager.SDK.Models.Login
{
    /// <summary>
    /// Login by email model
    /// </summary>
    public class LoginByEmailModel
    {
        /// <summary>
        /// Email
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Passwd { get; set; }

        /// <summary>
        /// Remember me
        /// </summary>
        public bool RememberMe { get; set; }

        /// <summary>
        /// Company id
        /// </summary>
        public int CompanyId { get; set; }
    }
}
