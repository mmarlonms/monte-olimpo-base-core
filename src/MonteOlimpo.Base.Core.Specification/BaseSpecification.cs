using MonteOlimpo.Base.Core.Domain.Model;
using MonteOlimpo.Base.Core.Domain.Specification;
using System;
using System.Linq.Expressions;

namespace MonteOlimpo.Base.Core.Specification
{
    public class BaseSpecification<T> : ISpecification<T>
    where T : ModelBase
    {
        private Expression<Func<T, bool>> Criteria { get; }

        private Func<T, bool> _function;

        private Func<T, bool> Function => _function ?? (_function = Criteria.Compile());

        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public bool IsSatisfiedBy(T entity)
        {
            return Function.Invoke(entity);
        }

        public Expression<Func<T, bool>> ToExpression()
        {
            return this.Criteria;
        }

        public BaseSpecification<T> And(BaseSpecification<T> newSpecification)
        {
            var leftExpr = this.Criteria;
            var rightExpr = newSpecification.Criteria;
            var leftParam = leftExpr.Parameters[0];
            var rightParam = rightExpr.Parameters[0];

            return new BaseSpecification<T>(
                Expression.Lambda<Func<T, bool>>(
                    Expression.AndAlso(
                        leftExpr.Body,
                        new ParameterReplacer(rightParam, leftParam).Visit(rightExpr.Body)),
                    leftParam));
        }

        public BaseSpecification<T> Or(BaseSpecification<T> newSpecification)
        {
            var leftExpr = this.Criteria;
            var rightExpr = newSpecification.Criteria;
            var leftParam = leftExpr.Parameters[0];
            var rightParam = rightExpr.Parameters[0];

            return new BaseSpecification<T>(
                Expression.Lambda<Func<T, bool>>(
                    Expression.OrElse(
                        leftExpr.Body,
                        new ParameterReplacer(rightParam, leftParam).Visit(rightExpr.Body)),
                    leftParam));
        }

        internal class ParameterReplacer : ExpressionVisitor
        {
            private readonly ParameterExpression _parameter;
            private readonly ParameterExpression _replacement;

            public ParameterReplacer(ParameterExpression parameter, ParameterExpression replacement)
            {
                _parameter = parameter;
                _replacement = replacement;
            }

            protected override Expression VisitParameter(ParameterExpression node)
            {
                return base.VisitParameter(_parameter == node ? _replacement : node);
            }
        }
    }
}