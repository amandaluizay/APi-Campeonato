namespace Campeonato.CL.Domain.Entities.FutebolDB
{
    public class FaseAtual : Entity
    {
        public string? Tipo { get; set; }
        public string? Link { get; set; }

        public Campeonato? Campeonato { get; set; }
        public Guid? CampeonatoId { get; set; }
    }
}