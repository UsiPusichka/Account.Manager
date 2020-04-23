using Account.Manager.Repository.Abstract;
using Account.Manager.Repository.Context;
using Account.Manager.Repository.Entities;

namespace Account.Manager.Repository.Concrete
{
    public class TokenRepository : CrudRepository<Token>, ITokenRepository
    {
        public TokenRepository(DataContext context) : base(context)
        {
        }
    }
}
