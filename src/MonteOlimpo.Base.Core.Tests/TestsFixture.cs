using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MonteOlimpo.Base.Core.Data.UnitOfWork;
using MonteOlimpo.Base.Core.Domain.UnitOfWork;
using MonteOlimpo.Base.Extensions.Service;
using System.Collections.Generic;
using System.Reflection;

namespace MonteOlimpo.Base.Core.Tests
{
    public abstract class TestsFixture<Context>
        where Context : DbContext
    {
        public ServiceProvider ServiceProvider { get; private set; }

        protected TestsFixture()
        {
            var serviceCollection = new ServiceCollection();

            // Add a database context (ApplicationDbContext) using an in-memory 
            // database for testing.
            serviceCollection.AddDbContext<Context>(options =>
            {
                options.UseInMemoryDatabase("InMemoryDbForTesting");
                options.UseInternalServiceProvider(this.ServiceProvider);
            });

            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork<Context>>();

            serviceCollection.RegisterAllTypes(GetAditionalAssemblies());

            this.ServiceProvider = serviceCollection
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();
        }

        protected abstract IEnumerable<Assembly> GetAditionalAssemblies();
    }
}
