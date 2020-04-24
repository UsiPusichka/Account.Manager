namespace Account.Manager.SDK.Models.Auth
{
    /// <summary>
    /// Auth token model
    /// </summary>
    public class AuthTokenModel
    {
        public AuthTokenModel()
        {
            AccessToken = new AuthTokenDataModel();
        }

        /// <summary>
        /// Fixed phone number
        /// </summary>
        public long ValidPhone { get; set; }

        /// <summary>
        /// Token data
        /// </summary>
        public AuthTokenDataModel AccessToken { get; set; }
    }
}
