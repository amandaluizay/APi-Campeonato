using Campeonato.API.Internal.Response;
using CampeonatoEntity = Campeonato.CL.Domain.Entities.FutebolDB.Campeonato;

namespace Campeonato.API.Internal.Profile
{
    public class CampeonatoByTemporadaProfile : AutoMapper.Profile
    {
        public CampeonatoByTemporadaProfile()
        {
            CreateMap<CampeonatoEntity, CampeonatoByTemporadaResponse>()
            .ForMember(dst => dst.Temporada, opt => opt.MapFrom(src => src.EdicaoAtual.Temporada));
        }
    }
}
