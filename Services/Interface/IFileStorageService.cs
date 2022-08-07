using WebShopSeminar.Models.ViewModel;

namespace WebShopSeminar.Services.Interface
{
    public interface IFileStorageService
    {
        Task<FileStorageViewModel> AddFileToStorage(IFormFile file);
        Task<bool> DeleteFile(int id);
        Task<FileStorageExpendedViewModel> GetFile(long id);
    }
}