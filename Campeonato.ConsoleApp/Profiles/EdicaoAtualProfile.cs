using Campeonato.CL.Domain.Entities.FutebolDB;
using Campeonato.ConsoleApp.Models;

namespace Campeonato.ConsoleApp.Profiles
{
    internal class EdicaoAtualProfile : AutoMapper.Profile
    {
        public EdicaoAtualProfile()
        {
            CreateMap<EdicaoAtualResponse, EdicaoAtual>();
        }
    }   
}
