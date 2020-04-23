using Account.Manager.Repository.Abstract;
using Account.Manager.Repository.Context;
using Account.Manager.Repository.Entities;

namespace Account.Manager.Repository.Concrete
{
    public class CompanyRepository : CrudRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(DataContext context) : base(context)
        {
        }
    }
}
