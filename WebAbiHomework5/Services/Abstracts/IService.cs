using System.Linq.Expressions;

namespace WebAbiHomework5.Services.Abstracts;

public interface IService<T>
{
    Task<IEnumerable<T>> GetAll();
    Task<T> Get(Expression<Func<T, bool>> predicate);
    Task Add (T entity);
    void Delete (T entity);
    Task Update (T entity);
}
