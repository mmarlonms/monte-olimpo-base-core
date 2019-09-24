using Microsoft.EntityFrameworkCore;
using MonteOlimpo.Base.Core.Domain.UnitOfWork;
using System;

namespace MonteOlimpo.Base.Core.Data.UnitOfWork
{
    public class UnitOfWork<TContext> : IUnitOfWork, IDisposable
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
            GC.SuppressFinalize(this);
        }
    }
}