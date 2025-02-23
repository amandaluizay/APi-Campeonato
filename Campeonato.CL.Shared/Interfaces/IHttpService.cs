namespace Campeonato.CL.Shared.Interfaces
{
    public interface IHttpService
    {
        Task<byte[]> DownloadFileByUrl(string url);
        Task<T?> GetAsync<T>(string url, string? apiKey, List<string>? parameters = null);
    }
}