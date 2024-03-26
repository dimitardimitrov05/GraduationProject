namespace Резервирай_Преживяване.Contracts
{
    public interface IImageService
    {
        Task<string> UploadImageAsync(IFormFile imageFile, string name);
    }
}
