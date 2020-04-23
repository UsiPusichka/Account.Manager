using Account.Manager.Repository.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Account.Manager.Repository.Abstract
{
    public interface ICrudRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();

        Task<List<T>> FindBy(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// GetPage
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <param name="orderBy"></param>
        /// <param name="desc"></param>
        /// <returns>List of T plus total count.</returns>
        Task<(List<T> pageData, int totalCount)> GetPage(Expression<Func<T, bool>> predicate, int skip = 0, int take = int.MaxValue, string orderBy = "Id", bool desc = false);

        Task<T> Add(T entity);

        T Delete(long id);

        T Delete(T entity);

        void Edit(T entity);

        Task Save();
    }
}
