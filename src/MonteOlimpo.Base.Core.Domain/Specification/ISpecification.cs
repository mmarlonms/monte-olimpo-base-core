using MonteOlimpo.Base.Core.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MonteOlimpo.Base.Core.Domain.Specification
{
    public interface ISpecification<T>
      where T : ModelBase
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
    }
}