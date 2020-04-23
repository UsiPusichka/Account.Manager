using Account.Manager.Repository.Abstract;
using Account.Manager.Repository.Context;
using Account.Manager.Repository.Entities;

namespace Account.Manager.Repository.Concrete
{
    public class UserProfileRoleRepository : CrudRepository<UserProfileRole>, IUserProfileRoleRepository
    {
        public UserProfileRoleRepository(DataContext context) : base(context)
        {
        }
    }
}
