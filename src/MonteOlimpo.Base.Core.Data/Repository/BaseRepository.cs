using Microsoft.EntityFrameworkCore;
using MonteOlimpo.Base.Core.Domain.Model;
using MonteOlimpo.Base.Core.Domain.Repository;
using MonteOlimpo.Base.Core.Domain.Specification;
using MonteOlimpo.Base.Core.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MonteOlimpo.Base.Core.Data.Repository
{
    public class BaseRepository<T> : IRepository<T>
     where T : ModelBase
    {
        private readonly IUnitOfWork unitOfWork;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(T entity)
        {
            this.unitOfWork.Context.Set<T>().Add(entity);
            this.unitOfWork.Commit();
        }

        public void Delete(T entity)
        {
            T existing = this.unitOfWork.Context.Set<T>().Find(entity.Id);
            if (existing != null) this.unitOfWork.Context.Set<T>().Remove(existing);
            this.unitOfWork.Commit();
        }

        public IEnumerable<T> List()
        {
            return this.unitOfWork.Context.Set<T>().AsEnumerable<T>();
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            return this.unitOfWork.Context.Set<T>().Where(predicate).AsEnumerable<T>();
        }

        public T GetById(int id)
        {
            return this.unitOfWork.Context.Set<T>().Where(x => x.Id == id).SingleOrDefault();
        }

        public T GetBySpecification(ISpecification<T> specification)
        {
            return this.unitOfWork.Context.Set<T>().Where(specification.ToExpression()).SingleOrDefault();
        }

        public IEnumerable<T> ListBySpecfication(ISpecification<T> specification)
        {
            return this.unitOfWork.Context.Set<T>().Where(specification.ToExpression()).ToList();
        }

        public void Update(T entity)
        {
            this.unitOfWork.Context.Entry(entity).State = EntityState.Modified;
            this.unitOfWork.Commit();
        }
    }
}