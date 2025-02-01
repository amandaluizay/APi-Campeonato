using System.Text.Json.Serialization;

namespace Campeonato.ConsoleApp.Models
{
    internal class FaseAtualResponse
    {
        public Guid? CampeonatoId { get; set; }

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
}
