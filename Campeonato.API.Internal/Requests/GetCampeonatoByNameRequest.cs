namespace Campeonato.API.Internal.Requests
{
    public class GetCampeonatoByNameRequest
    {
        public string? Name { get; set; }
        public string? Slug { get; set; }
        public string? NomePopular { get; set; }
    }
}
