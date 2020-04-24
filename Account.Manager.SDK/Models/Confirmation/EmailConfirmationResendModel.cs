namespace Account.Manager.SDK.Models.Confirmation
{
    /// <summary>
    /// Resend Email with confirmation code model.
    /// </summary>
    public class EmailConfirmationResendModel
    {
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
