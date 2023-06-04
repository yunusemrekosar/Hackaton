using Hackaton.Services.Storage;

namespace Hackaton.Services.StorageAbs.LocalStorageAbs
{
    public interface ILocalStorage : IStorage
    {
        Task<bool> CopyFileAsync(string path, IFormFileCollection file);
    }
}
