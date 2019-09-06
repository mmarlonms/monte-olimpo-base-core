using Microsoft.EntityFrameworkCore;
using MonteOlimpo.Base.Core.Domain.UnitOfWork;

namespace MonteOlimpo.Base.Core.Data.UnitOfWork
{
    public class UnitOfWork<TContext> : IUnitOfWork
         where TContext : DbContext
    {
        public DbContext Context { get; set; }

        public UnitOfWork(TContext context)
        {
            Context = context;
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}