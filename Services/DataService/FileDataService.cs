namespace FerForge.Services.DataService
{
    internal class FileDataService : IDataService
    {
        public async Task<string> ReadAsync(string path)
        {
            return await File.ReadAllTextAsync(path);
        }

        public async Task WriteAsync(string path, string content)
        {
            await File.WriteAllTextAsync(path, content);
        }
    }
}
