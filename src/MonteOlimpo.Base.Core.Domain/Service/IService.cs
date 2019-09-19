using MonteOlimpo.Base.Core.Domain.Model;
using System.Collections.Generic;

namespace MonteOlimpo.Base.Core.Domain.Service
{
    public interface IService<T>
        where T: ModelBase
    {
        IList<T> GetAll();
        T GetByID(int id);
        T Create(T modelBase);
        T Update(T modelBase);
        void Delete(int id);
    }
}