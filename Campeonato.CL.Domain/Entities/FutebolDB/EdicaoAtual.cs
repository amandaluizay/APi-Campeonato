namespace Campeonato.CL.Domain.Entities.FutebolDB
{
    public class EdicaoAtual : Entity
    {
        public string? NomePopular { get; set; }
        public string? Temporada { get; set; }

        public Campeonato? Campeonato { get; set; }
        public Guid? CampeonatoId { get; set; }
    }
}