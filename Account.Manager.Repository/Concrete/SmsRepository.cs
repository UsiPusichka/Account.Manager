using Account.Manager.Repository.Abstract;
using Account.Manager.Repository.Context;
using Account.Manager.Repository.Entities;

namespace Account.Manager.Repository.Concrete
{
    public class SmsRepository : CrudRepository<Sms>, ISmsRepository
    {
        public SmsRepository(DataContext context) : base(context)
        {
        }
    }
}
