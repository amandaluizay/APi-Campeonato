using System.Text.Json.Serialization;

namespace Campeonato.ConsoleApp.Models
{
    internal class CampeonatoResponse
    {
        public Guid? CampeonatoId { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("nome_popular")]
        public string? NomePopular { get; set; }

        [JsonPropertyName("edicao_atual")]
        public EdicaoAtualResponse? EdicaoAtualResponse { get; set; }

        [JsonPropertyName("fase_atual")]
        public FaseAtualResponse? FaseAtualResponse { get; set; }

        [JsonPropertyName("rodada_atual")]
        public RodadaAtualResponse? RodadaAtualResponse { get; set; }

        [JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        [JsonPropertyName("_link")]
        public string? Link { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("logo")]
        public string? Logo { get; set; }

        [JsonPropertyName("regiao")]
        public string? Regiao { get; set; }

        [JsonPropertyName("slug")]
        public string? Slug { get; set; }

        public CampeonatoResponse()
        {
            CampeonatoId = Guid.NewGuid();
        }

        public void SetCampeonatoId()
        {
            if (FaseAtualResponse != null)
                FaseAtualResponse.CampeonatoId = CampeonatoId;

            if(EdicaoAtualResponse != null)
                EdicaoAtualResponse.CampeonatoId = CampeonatoId;

            if (RodadaAtualResponse != null)
                RodadaAtualResponse.CampeonatoId = CampeonatoId;
        }
    }
}
