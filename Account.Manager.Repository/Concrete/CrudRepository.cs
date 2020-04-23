using Account.Manager.Repository.Abstract;
using Account.Manager.Repository.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Account.Manager.Repository.Extensions;

namespace Account.Manager.Repository.Concrete
{
    public abstract class CrudRepository<T> : ICrudRepository<T> where T : BaseEntity
    {
        // TODO: add null validations
        protected DbContext _context;
        protected readonly DbSet<T> _dbset;

        public CrudRepository(DbContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }

        public virtual async Task<(List<T> pageData, int totalCount)> GetPage(Expression<Func<T, bool>> predicate,
            int skip = 0, int take = int.MaxValue, string orderBy = "Id", bool desc = false)
        {
            var query = _dbset.Where(predicate);
            query = query.OrderBy(orderBy, desc);
            var totalCount = await query.CountAsync();
            query = query.Skip(skip).Take(take);

            return (await query.ToListAsync(), totalCount);
        }

        public virtual async Task<List<T>> GetAll() =>
            await _dbset.ToListAsync();

        public virtual async Task<List<T>> FindBy(Expression<Func<T, bool>> predicate) =>
            await _dbset.Where(predicate).ToListAsync();

        public virtual async Task<T> Add(T entity) =>
            (await _dbset.AddAsync(entity)).Entity;

        public virtual T Delete(long id)
        {
            var obj = _dbset.First(e => e.Id == id);
            return _dbset.Remove(obj).Entity;
        }

        public virtual T Delete(T entity) =>
            _dbset.Remove(entity).Entity;

        public virtual void Edit(T entity) =>
            _dbset.Update(entity);

        public virtual async Task Save() =>
            await _context.SaveChangesAsync();
    }
}
