﻿namespace Campeonato.CL.Domain.Entities.FutebolDB
{
    public class RodadaAtual
    {
        public int? Rodada { get; set; }
        public string? Status { get; set; }

        public Campeonato? Campeonato { get; set; }
        public Guid? CampeonatoId { get; set; }
    }
}