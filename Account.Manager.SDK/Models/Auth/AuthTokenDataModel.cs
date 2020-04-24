namespace Account.Manager.SDK.Models.Auth
{
    /// <summary>
    /// Auth token data model
    /// </summary>
    public class AuthTokenDataModel
    {
        /// <summary>
        /// Access token
        /// </summary>
        public string Access_Token { get; set; }

        /// <summary>
        /// Refresh token
        /// </summary>
        public string Refresh_Token { get; set; }

        /// <summary>
        /// User profile id
        /// </summary>
        public long User_Id { get; set; }

        /// <summary>
        /// User id
        /// </summary>
        public long Account_Id { get; set; }

        /// <summary>
        /// Expires at unix timestamp
        /// </summary>
        public long Expires { get; set; }
    }
}
