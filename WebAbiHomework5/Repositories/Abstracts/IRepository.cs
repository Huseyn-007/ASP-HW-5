using System.Linq.Expressions;

namespace WebAbiHomework5.Repositories.Abstracts
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Expression<Func<T, bool>> predicate);
        Task Add(T entity);
        Task Update(T entity);
        void Delete(T entity);
    }
}
