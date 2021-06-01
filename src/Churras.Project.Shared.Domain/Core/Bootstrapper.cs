using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Churras.Project.Shared.Domain.Core
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddSharedInjections(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddFluentValidation();
            return services;
        }
    }
}
