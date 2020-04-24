using Account.Manager.Service.Inner.Abstract;

namespace Account.Manager.Service.Inner.Concrete
{
    public class RequestContext : IRequestContext
    {
        private const string DefaultLang = "ru";

        public void InitContext(string acceptLanguage)
        {
            Lang = acceptLanguage;
        }

        public string Lang { get; private set; } = DefaultLang;
    }
}
