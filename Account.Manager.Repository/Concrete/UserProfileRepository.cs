using Account.Manager.Repository.Abstract;
using Account.Manager.Repository.Context;
using Account.Manager.Repository.Entities;

namespace Account.Manager.Repository.Concrete
{
    public class UserProfileRepository : CrudRepository<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(DataContext context) : base(context)
        {
        }

    }
}
