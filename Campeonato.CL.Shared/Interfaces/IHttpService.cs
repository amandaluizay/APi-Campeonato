namespace Campeonato.CL.Shared.Interfaces
{
    public interface IHttpService
    {
        Task<T?> GetAsync<T>(string url, string? apiKey, List<string>? parameters = null);
    }
}