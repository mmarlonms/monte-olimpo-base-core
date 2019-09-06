using Microsoft.EntityFrameworkCore;

namespace MonteOlimpo.Base.Core.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        DbContext Context { get; }
        void Commit();
    }
}