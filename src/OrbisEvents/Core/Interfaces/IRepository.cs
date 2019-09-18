using System;
using System.Linq;
using System.Linq.Expressions;

namespace OrbisEvents.Core.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> FindAll();

        IQueryable<T> FindBy(Expression<Func<T, bool>> expression);

        void Save(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}