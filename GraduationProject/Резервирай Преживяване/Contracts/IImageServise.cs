namespace Резервирай_Преживяване.Contracts
{
    public interface IImageServise
    {
        Task<string> UploadImageAsync(IFormFile imageFile, string name);
    }
}
