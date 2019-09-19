using System.Collections.Generic;
using System.Linq;
using MonteOlimpo.Base.Core.Domain.Model;
using MonteOlimpo.Base.Core.Domain.Repository;
using MonteOlimpo.Base.Core.Domain.Service;

namespace MonteOlimpo.Base.Core.Service
{
    public class BaseService<T> : IService<T>
        where T : ModelBase
    {
        private readonly IRepository<T> repository;

        public BaseService(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public T Create(T modelBase)
        {
            this.repository.Add(modelBase);
            return modelBase;
        }

        public void Delete(int id)
        {
            var item = this.repository.GetById(id);
            if (item != null)
                this.repository.Delete(item);
        }

        public IList<T> GetAll()
        {
            return this.repository.List().ToList();
        }

        public T GetByID(int id)
        {
            return this.repository.GetById(id);
        }

        public T Update(T modelBase)
        {
            this.repository.Update(modelBase);
            return modelBase;
        }
    }
}