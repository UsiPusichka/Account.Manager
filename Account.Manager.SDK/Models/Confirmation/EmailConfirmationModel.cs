namespace Account.Manager.SDK.Models.Confirmation
{
    /// <summary>
    /// Confirm Email by code model.
    /// </summary>
    public class EmailConfirmationModel
    {
        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; set; }

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
