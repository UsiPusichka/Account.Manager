namespace Account.Manager.SDK.Models.Login
{
    /// <summary>
    /// Login by code model
    /// </summary>
    public class LoginByCodeModel
    {
        /// <summary>
        /// User phone (cell)
        /// </summary>
        public long Phone { get; set; }

        /// <summary>
        /// Code from SMS OR Refresh Token
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Company id
        /// </summary>
        public int CompanyId { get; set; }
    }
}
