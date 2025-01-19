using Campeonato.CL.Ioc;
using Campeonato.CL.Shared.Interfaces;
using Campeonato.ConsoleApp.Configuration;
using Campeonato.ConsoleApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

var basePath = Directory.GetCurrentDirectory();

var configuration = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

var services = new ServiceCollection();

services.Configure<ApiFutebolConfig>(config => configuration.GetRequiredSection(nameof(ApiFutebolConfig)).Bind(config));

var serviceProvider = services.AddServices(configuration)
                               .AddHttpClient()
                               .BuildServiceProvider();

var httpService = serviceProvider.GetRequiredService<IHttpService>();
var apiConfig = serviceProvider.GetRequiredService<IOptions<ApiFutebolConfig>>().Value;

var response = await httpService.GetAsync<List<CampeonatoResponse>>(apiConfig.BaseUrl, apiConfig.ApiKey);

;

