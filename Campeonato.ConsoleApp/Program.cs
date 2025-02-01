using AutoMapper;
using Campeonato.CL.Domain.Entities.FutebolDB;
using Campeonato.CL.Domain.Interfaces.Repository;
using Campeonato.CL.Ioc;
using Campeonato.CL.Shared.Interfaces;
using Campeonato.ConsoleApp.Configuration;
using Campeonato.ConsoleApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Reflection;
using CampeonatoEntity = Campeonato.CL.Domain.Entities.FutebolDB.Campeonato;

var basePath = Directory.GetCurrentDirectory();

var configuration = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

var services = new ServiceCollection();

services.Configure<ApiFutebolConfig>(config => configuration.GetRequiredSection(nameof(ApiFutebolConfig)).Bind(config));


var serviceProvider = services.AddServices(configuration)
                               .AddHttpClient()
                               .AddAutoMapper(Assembly.GetExecutingAssembly())
                               .BuildServiceProvider()
                               ;

var httpService = serviceProvider.GetRequiredService<IHttpService>();
var autoMapper = serviceProvider.GetRequiredService<IMapper>();

var campeonatoRepository = serviceProvider.GetRequiredService<IRepository<CampeonatoEntity>>();
var rodadaRepository = serviceProvider.GetRequiredService<IRepository<RodadaAtual>>();
var faseRepository = serviceProvider.GetRequiredService<IRepository<FaseAtual>>();
var edicaoRepository = serviceProvider.GetRequiredService<IRepository<EdicaoAtual>>();

var apiConfig = serviceProvider.GetRequiredService<IOptions<ApiFutebolConfig>>().Value;

var campeonatoResponse = await httpService.GetAsync<List<CampeonatoResponse>>(apiConfig.BaseUrl, apiConfig.ApiKey);

campeonatoResponse.ForEach(i => i.SetCampeonatoId());

var rodadasResponse = campeonatoResponse.Where(i=> i.RodadaAtualResponse != null)
                                        .Select(i => i.RodadaAtualResponse)
                                        .ToList();

var fasesResponse = campeonatoResponse.Where(i => i.FaseAtualResponse != null)
                                      .Select(i => i.FaseAtualResponse)
                                      .ToList();

var edicaoResponse = campeonatoResponse.Where(i => i.EdicaoAtualResponse != null)
                                       .Select(i => i.EdicaoAtualResponse)
                                       .ToList();

var campeonatos = autoMapper.Map<List<CampeonatoEntity>>(campeonatoResponse);

var rodadas = autoMapper.Map<List<RodadaAtual>>(rodadasResponse);
var fases = autoMapper.Map<List<FaseAtual>>(fasesResponse);
var edicoes = autoMapper.Map<List<EdicaoAtual>>(edicaoResponse);

await campeonatoRepository.AddRangeAsync(campeonatos);
await rodadaRepository.AddRangeAsync(rodadas);
await faseRepository.AddRangeAsync(fases);
await edicaoRepository.AddRangeAsync(edicoes);






