using Churras.Project.Db.Repository.Churrasco;
using Churras.Project.Domain.Contract.v1;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Churras.Project.Db.Core
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddDbInjections(this IServiceCollection services, IConfiguration configuration)
        {
            var dbConfiguration = configuration.GetSection(nameof(DatabaseConfiguration)).Get<DatabaseConfiguration>();
            services.AddSingleton(dbConfiguration);
            services.AddRepositories();

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient(typeof(IChurrascoServiceRepository), typeof(ChurrascoRepository));
            return services;
        }
    }
}
