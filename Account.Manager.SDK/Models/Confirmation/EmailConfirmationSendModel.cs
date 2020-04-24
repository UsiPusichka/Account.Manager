namespace Account.Manager.SDK.Models.Confirmation
{
    /// <summary>
    /// Send Email with confirmation code model.
    /// </summary>
    public class EmailConfirmationSendModel
    {
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// UserProfileId
        /// </summary>
        public long UserProfileId { get; set; }

        /// <summary>
        /// UserId
        /// </summary>
        public long UserId { get; set; }
    }
}
