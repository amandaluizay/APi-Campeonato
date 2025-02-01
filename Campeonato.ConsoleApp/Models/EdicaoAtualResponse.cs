using System.Text.Json.Serialization;

namespace Campeonato.ConsoleApp.Models
{
    internal class EdicaoAtualResponse
    {
        public Guid? CampeonatoId { get; set; }
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
}
