using Campeonato.ConsoleApp.Models;
using CampeonatoEntity = Campeonato.CL.Domain.Entities.FutebolDB.Campeonato;

namespace Campeonato.ConsoleApp.Profiles
{
    internal class CampeonatoProfile : AutoMapper.Profile
    {
        public CampeonatoProfile()
        {
            CreateMap<CampeonatoResponse, CampeonatoEntity>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CampeonatoId))
            .ReverseMap();
        }
    }
    
}
