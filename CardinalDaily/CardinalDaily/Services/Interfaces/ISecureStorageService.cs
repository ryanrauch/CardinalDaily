using System.Threading.Tasks;

namespace CardinalDaily.Services.Interfaces
{
    public interface ISecureStorageService
    {
        Task<string> ReadDataAsync(string key);
        Task<bool> WriteDataAsync(string key, string val);
    }
}