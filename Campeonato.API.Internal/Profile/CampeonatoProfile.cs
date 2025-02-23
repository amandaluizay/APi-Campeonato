using Campeonato.API.Internal.Response;
using CampeonatoEntity = Campeonato.CL.Domain.Entities.FutebolDB.Campeonato;

namespace Campeonato.API.Internal.Profile
{
    public class CampeonatoProfile : AutoMapper.Profile
    {
        public CampeonatoProfile()
        {
            CreateMap<CampeonatoEntity, CampeonatoResponse>();
        }
    }

    public class CampeonatoByStatusProfile : AutoMapper.Profile
    {
        public CampeonatoByStatusProfile()
        {
            CreateMap<CampeonatoEntity, CampeonatoByStatusResponse>()
            .ForMember(dest => dest.RodadaAtualStatus, opt => opt.MapFrom(src => src.RodadaAtual.Status));
        }
    }
}
