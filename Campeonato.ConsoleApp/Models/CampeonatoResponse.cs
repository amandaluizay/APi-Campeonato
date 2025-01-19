using System.Text.Json.Serialization;

namespace Campeonato.ConsoleApp.Models
{
    internal class CampeonatoResponse
    {
        [JsonPropertyName("campeonato_id")]
        public int? CampeonatoId { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("nome_popular")]
        public string? NomePopular { get; set; }

        [JsonPropertyName("edicao_atual")]
        public EdicaoAtualResponse? EdicaoAtual { get; set; }

        [JsonPropertyName("fase_atual")]
        public FaseAtualResponse? FaseAtual { get; set; }

        [JsonPropertyName("rodada_atual")]
        public RodadaAtualResponse? RodadaAtual { get; set; }

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
    }

    internal class EdicaoAtualResponse
    {
        [JsonPropertyName("edicao_id")]
        public int? EdicaoId { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("nome_popular")]
        public string? NomePopular { get; set; }

        [JsonPropertyName("slug")]
        public string? Slug { get; set; }

        [JsonPropertyName("temporada")]
        public string? Temporada { get; set; }
    }

    internal class FaseAtualResponse
    {
        [JsonPropertyName("fase_id")]
        public int? FaseId { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("slug")]
        public string? Slug { get; set; }

        [JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        [JsonPropertyName("_link")]
        public string? Link { get; set; }
    }

    internal class RodadaAtualResponse
    {
        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("slug")]
        public string? Slug { get; set; }

        [JsonPropertyName("rodada")]
        public int? Rodada { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}
