using Account.Manager.Service.Inner.Abstract;

namespace Account.Manager.Service.Inner.Concrete
{
    public class EnvironmentProvider : IEnvironmentProvider
    {
        public bool IsProduction { get; set; }

        public int MaxActiveTokens { get; set; }

        public bool SilentMode { get; set; } = false;

        public int SignUpRetryPeriodInSeconds { get; set; } = 60;

        public int SignUpRetryCount { get; set; } = 1;

        public int SignInRetryPeriodInSeconds { get; set; } = 60;

        public int SignInRetryCount { get; set; } = 3;

        public int MaxAttemptsSendEmail { get; set; } = 3;

        public int MaxAttemptsReSendEmail { get; set; } = 3;

        public int FreezeSending { get; set; } = 300;

        public int MaxUnsuccessfulAttempt { get; set; } = 3;

        public int FreezeUnsuccessfulSending { get; set; } = 60;

        public int CodeExpire { get; set; } = 120;

        public string WebPortalUrl { get; set; }

        public int ForgotPasswordExpiryTime { get; set; } = 600;

        public int InviteExpire { get; set; } = 172800;
    }
}
