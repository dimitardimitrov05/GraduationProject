using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Резервирай_Преживяване.Contracts;

namespace Резервирай_Преживяване.Services
{
    public class ImageService : IImageService
    {
        private readonly Cloudinary cloudinary;

        public ImageService(Cloudinary cloudinary)
        {
            this.cloudinary = cloudinary;
        }

        public async Task<string> UploadImageAsync(IFormFile imageFile, string name)
        {
            using var stream = imageFile.OpenReadStream();
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(name, stream)
            };
            var uploadResult = await cloudinary.UploadAsync(uploadParams);
            return uploadResult.SecureUrl.ToString();
        }
    }
}
