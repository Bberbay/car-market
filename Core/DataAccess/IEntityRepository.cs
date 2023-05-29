using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess;
// Generic Repo
// T reference type 
public interface IEntityRepository<T> where T:class,IEntity,new()
{
    T Get(Expression<Func<T,bool>> filter);
    IList<T> GetList(Expression<Func<T,bool>>? filter=null);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}