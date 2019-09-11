using MonteOlimpo.Base.Core.Domain.Model;
using System;
using System.Linq.Expressions;

namespace MonteOlimpo.Base.Core.Domain.Specification
{
    public interface ISpecification<T>
      where T : ModelBase
    {
        bool IsSatisfiedBy(T entity);

        Expression<Func<T, bool>> ToExpression();
    }
}