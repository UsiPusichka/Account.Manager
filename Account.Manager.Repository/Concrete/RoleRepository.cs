using Account.Manager.Repository.Abstract;
using Account.Manager.Repository.Context;
using Account.Manager.Repository.Entities;

namespace Account.Manager.Repository.Concrete
{
    public class RoleRepository : CrudRepository<Role>, IRoleRepository
    {
        public RoleRepository(DataContext context) : base(context)
        {
        }
    }
}
