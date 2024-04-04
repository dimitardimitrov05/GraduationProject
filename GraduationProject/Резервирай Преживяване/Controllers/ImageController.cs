using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Models.Account;

namespace Резервирай_Преживяване.Controllers
{
    [Authorize]
    public class ImageController : Controller
    {
        private readonly IImageService servise;

        public ImageController(IImageService servise)
        {
            this.servise = servise;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Upload(UserViewModel model)
        {
            var image = model.Picture;
            if (image != null && image.Length > 0)
            {
                var imageUrl = await servise.UploadImageAsync(image, "cars");
                ViewBag.ImageUrl = imageUrl;
            }
            return RedirectToAction("UserProfile", "Account");
        }
    }
}
