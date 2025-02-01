using Campeonato.CL.Domain.Entities.FutebolDB;
using Campeonato.ConsoleApp.Models;

namespace Campeonato.ConsoleApp.Profiles
{
    internal class RodadaAtualProfile : AutoMapper.Profile
    {
        public RodadaAtualProfile()
        {
            CreateMap<RodadaAtualResponse, RodadaAtual>();
        }
    }
}
