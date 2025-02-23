using AutoMapper;
using Campeonato.API.Internal.Requests;
using Campeonato.API.Internal.Response;
using Campeonato.CL.Domain.Entities.FutebolDB;
using Campeonato.CL.Domain.Interfaces.Repository;
using Campeonato.CL.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CampeonatoEntity = Campeonato.CL.Domain.Entities.FutebolDB.Campeonato;

namespace Campeonato.API.Internal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampeonatoController : ControllerBase
    {
        private readonly IRepository<CampeonatoEntity> _campeonatoRepository;
        private readonly IMapper _mapper;
        private readonly IHttpService _httpService;
        public CampeonatoController(IRepository<CampeonatoEntity> campeonatoRepository, IMapper mapper, IHttpService httpService)
        {
            _campeonatoRepository = campeonatoRepository;
            _mapper = mapper;
            _httpService = httpService;
        }

        [HttpGet("campeonatos")]
        public async Task<IActionResult> Get()
        {
            var campeonatos = await _campeonatoRepository.GetAsync();
            return Ok(_mapper.Map<List<CampeonatoResponse>>(campeonatos));
        }

        [HttpGet("campeonatos/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var campeonato = await _campeonatoRepository.GetByIdAsync(id);
            
            if (campeonato == null)
            {
                return NotFound();
            }
            
            return Ok(_mapper.Map<CampeonatoResponse>(campeonato));
        }

        [HttpPost("campeonatos/{id}")]
        public async Task<IActionResult> GetByName(Guid id, [FromBody] GetCampeonatoByNameRequest request)
        {
            var campeonato = await _campeonatoRepository.Entities
                                   .FirstOrDefaultAsync(c => c.Id == id && c.Nome == request.Name && c.Slug == request.Slug && c.NomePopular == request.NomePopular);

            return Ok(_mapper.Map<CampeonatoResponse>(campeonato));
        }

        [HttpGet("campeonatos/temporada/{temporada}")]
        public async Task<IActionResult> GetByTemporada(string temporada)
        {
            var campeonatos = await _campeonatoRepository.Entities
                                                         .Include(c => c.EdicaoAtual)
                                                         .Where(c => c.EdicaoAtual != null && c.EdicaoAtual.Temporada == temporada)
                                                         .ToListAsync();

            return Ok(_mapper.Map<List<CampeonatoByTemporadaResponse>>(campeonatos));
        }

        [HttpPost("campeonatos/status/{status}")]
        public async Task<IActionResult> GetByStatus(string status)
        {
            var campeonatos = await _campeonatoRepository.Entities
                                                         .Include(c => c.RodadaAtual)
                                                         .Where(c => c.RodadaAtual != null && c.RodadaAtual.Status == status)
                                                         .ToListAsync();

            return Ok(_mapper.Map<List<CampeonatoByStatusResponse>>(campeonatos));
        }

        [HttpGet("campeonatos/logo/{id}")]
        public async Task<IActionResult> GetLogoAsync(Guid id)
        {
            var logoUrl = await _campeonatoRepository.Entities.Where(i => i.Id == id).Select(i => i.Logo).FirstOrDefaultAsync()
                        ?? throw new Exception("Logo not found");

            var file = await _httpService.DownloadFileByUrl(logoUrl);

            return File(file, "image/png", "Logo.png");
        }
    }
}
