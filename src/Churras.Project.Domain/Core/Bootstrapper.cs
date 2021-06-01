using Churras.Project.Domain.Commands.v1.CriarChurrasco;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Churras.Project.Domain.Core
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddDomainInjections(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddMediatRInjections(configuration)
                .AddValidatorsInjections(configuration);

            return services;
        }

        private static IServiceCollection AddMediatRInjections(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddMediatR(typeof(CriarChurrascoCommand).GetTypeInfo().Assembly);
            return services;
        }

        private static IServiceCollection AddValidatorsInjections(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IValidator<CriarChurrascoCommand>, CriarChurrascoCommandValidator>();
            return services;
        }
    }
}
