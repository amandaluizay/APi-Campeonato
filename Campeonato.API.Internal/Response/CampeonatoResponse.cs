namespace Campeonato.API.Internal.Response
{
    public class CampeonatoResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Slug { get; set; }
        public string? NomePopular { get; set; }
        public string? Status { get; set; }
        public string? Tipo { get; set; }
        public string? Logo { get; set; }
        public string? Regiao { get; set; }
    }
}
