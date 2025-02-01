using Campeonato.CL.Domain.Entities.FutebolDB;
using Campeonato.ConsoleApp.Models;

namespace Campeonato.ConsoleApp.Profiles
{
    internal class FaseAtualProfile : AutoMapper.Profile
    {
        public FaseAtualProfile()
        {
            CreateMap<FaseAtualResponse, FaseAtual>();
        }
    }
}
