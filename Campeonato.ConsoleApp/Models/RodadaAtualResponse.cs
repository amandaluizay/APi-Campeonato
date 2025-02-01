using System.Text.Json.Serialization;

namespace Campeonato.ConsoleApp.Models
{
    internal class RodadaAtualResponse
    {
        public Guid? CampeonatoId { get; set; }

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
