namespace Campeonato.CL.Domain.Entities.FutebolDB
{
    public class Campeonato : Entity
    {
        public string? NomePopular { get; set; }
        public string? Status { get; set; }
        public string? Tipo { get; set; }
        public string? Logo { get; set; }
        public string? Região { get; set; }

        public RodadaAtual? RodadaAtual { get; set; }
        public EdicaoAtual? EdicaoAtual { get; set; }
        public FaseAtual? FaseAtual { get; set; }
    }
}
