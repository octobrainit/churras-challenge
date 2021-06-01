using Churras.Project.Db.Core;
using Churras.Project.Domain.Core;
using Churras.Project.Shared.Domain.Core;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Churras.Project.API.Core
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddInjectionsProject(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.IgnoreNullValues = true;
                });
            services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Churras.Project.API", Version = "v1" });
                });

            services.AddMediatR(typeof(Startup));

            services
                .AddSharedInjections(configuration)
                .AddDbInjections(configuration)
                .AddDomainInjections(configuration);

            return services;
        }
    }
}
