using Account.Manager.Repository.Abstract;
using Account.Manager.Repository.Context;
using Account.Manager.Repository.Entities;

namespace Account.Manager.Repository.Concrete
{
    public class EmailHashRepository : CrudRepository<EmailHash>, IEmailHashRepository
    {
        public EmailHashRepository(DataContext context) : base(context)
        {
        }
    }
}
