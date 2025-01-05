namespace FerForge.Services.DataService
{
    internal interface IDataService
    {
        Task<string> ReadAsync(string path);
        Task WriteAsync(string path, string content);
    }
}
