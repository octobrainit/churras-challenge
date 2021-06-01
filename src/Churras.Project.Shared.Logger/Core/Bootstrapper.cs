using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Churras.Project.Shared.Logger.Core
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddLogger(this IServiceCollection services, IConfiguration configuration)
        {

            return services;
        }
    }
}
