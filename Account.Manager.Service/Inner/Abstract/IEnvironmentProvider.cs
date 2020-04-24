namespace Account.Manager.Service.Inner.Abstract
{
    public interface IEnvironmentProvider
    {
        /// <summary>
        /// We are in PROD environment?
        /// </summary>
        bool IsProduction { get; set; }

        /// <summary>
        /// Max amount of active user tokens at the moment 
        /// </summary>
        int MaxActiveTokens { get; set; }

        /// <summary>
        /// Get token without SMS validation during registration, except PRODUCTION env
        /// </summary>
        bool SilentMode { get; set; }

        /// <summary>
        /// SignUp retry period in seconds
        /// </summary>
        int SignUpRetryPeriodInSeconds { get; set; }

        /// <summary>
        /// SignUp retry count per period
        /// </summary>
        int SignUpRetryCount { get; set; }

        /// <summary>
        /// SignIn retry period in seconds
        /// </summary>
        int SignInRetryPeriodInSeconds { get; set; }

        /// <summary>
        /// SignIn retry per period
        /// </summary>
        int SignInRetryCount { get; set; }

        /// <summary>
        /// Max attempts for send email
        /// </summary>
        int MaxAttemptsSendEmail { get; set; }

        /// <summary>
        /// Max attempts for resend email
        /// </summary>
        int MaxAttemptsReSendEmail { get; set; }

        /// <summary>
        /// Time for which sending codes is frozen (sec)
        /// </summary>
        int FreezeSending { get; set; }

        /// <summary>
        /// MaxUnsuccessfulAttempt
        /// </summary>
        int MaxUnsuccessfulAttempt { get; set; }

        /// <summary>
        /// Freeze Unsuccessful Sending (sec)
        /// </summary>
        int FreezeUnsuccessfulSending { get; set; }

        /// <summary>
        /// Time after which the code expires (sec)
        /// </summary>
        int CodeExpire { get; set; }

        /// <summary>
        /// Web portal url
        /// </summary>
        string WebPortalUrl { get; set; }

        /// <summary>
        /// Forgot password expiry time (in sec)
        /// </summary>
        int ForgotPasswordExpiryTime { get; set; }

        /// <summary>
        /// Invite expiry time (in sec)
        /// </summary>
        int InviteExpire { get; set; }
    }
}
