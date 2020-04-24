namespace Account.Manager.Service.Inner.Abstract
{
    public interface IRequestContext
    {
        void InitContext(string acceptLanguage);

        string Lang { get; }
    }
}
