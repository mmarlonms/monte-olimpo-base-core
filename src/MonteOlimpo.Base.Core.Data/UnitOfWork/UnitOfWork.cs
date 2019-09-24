using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using MonteOlimpo.Base.Core.Domain.UnitOfWork;
using System;
using System.Runtime.InteropServices;

namespace MonteOlimpo.Base.Core.Data.UnitOfWork
{
    /// <summary>
    ///     Implementado segundo o dispose patern:
    ///     https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public class UnitOfWork<TContext> : IUnitOfWork, IDisposable
         where TContext : DbContext
    {
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

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
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                Context.Dispose();
            }

            disposed = true;
        }

    }
}