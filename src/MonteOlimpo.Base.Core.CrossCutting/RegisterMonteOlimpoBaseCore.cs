using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MonteOlimpo.Base.Core.Data.UnitOfWork;
using MonteOlimpo.Base.Core.Domain.UnitOfWork;
using MonteOlimpo.Base.Extensions.Configuration;

namespace MonteOlimpo.Base.Core.CrossCutting
{
    public static class RegisterMonteOlimpoBaseCore
    {
        public static IServiceCollection RegisterMonteOlimpoDataBase<TContext>(this IServiceCollection services, IConfiguration configuration)
           where TContext : DbContext
        {
            var config = configuration.TryGet<BaseRepositoryConfiguration>();
            
            switch (config.RepositoryType)
            {
                case RepositoryType.SQLServer:
                    services.AddDbContext<TContext>(options =>
                        options.UseSqlServer(configuration.GetConnectionString(typeof(TContext).Name)));
                    break;
                default:
                    services.AddEntityFrameworkNpgsql()
                     .AddDbContext<TContext>(
                         options => options.UseNpgsql(
                             configuration.GetConnectionString(typeof(TContext).Name)));
                    break;
            }

            services.AddScoped<IUnitOfWork, UnitOfWork<TContext>>();

            return services;
        }
    }
}