using MonteOlimpo.Base.Core.Domain.Model;
using MonteOlimpo.Base.Core.Domain.Specification;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MonteOlimpo.Base.Core.Domain.Repository
{
    public interface IRepository<T> where T : ModelBase
    {
        T GetById(int id);

        IEnumerable<T> List();

        IEnumerable<T> List(Expression<Func<T, bool>> predicate);

        IEnumerable<T> ListBySpecfication(ISpecification<T> specification);

        T GetBySpecification(ISpecification<T> specification);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}