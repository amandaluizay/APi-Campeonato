using Campeonato.DB.Futebol;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Campeonato.CL.Shared.Configuration;
using Microsoft.Extensions.Options;
using Campeonato.CL.Domain.Interfaces.Repository;
using Campeonato.DB.Futebol.Repository;
using Campeonato.CL.Shared.Interfaces;
using Campeonato.CL.Shared.Services;

namespace Campeonato.CL.Ioc
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<FutebolDbConfig>(config => configuration.GetRequiredSection(nameof(FutebolDbConfig)).Bind(config));

            services.AddDbContext<FutebolDbContext>((serviceProvider, options) =>
            {
                var futebolDbConfig = serviceProvider.GetRequiredService<IOptions<FutebolDbConfig>>().Value;

                options.UseSqlServer(futebolDbConfig.ConnectionString);
            });

            services.AddTransient(typeof(IRepository<>), typeof(EFRepository<>));

            services.AddTransient<IHttpService, HttpService>();

            return services;
        }
    }
}
