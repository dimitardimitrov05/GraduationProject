using Microsoft.AspNetCore.Mvc;
using Резервирай_Преживяване.Contracts;

namespace Резервирай_Преживяване.Controllers
{
    public class LandmarksController : Controller
    {
        private readonly ILandmarkService service;

        public LandmarksController(ILandmarkService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            var landmarks = await service.GetAllLandmarksAsync();
            return View(landmarks);
        }

        public async Task<IActionResult> EachLandmark(Guid id)
        {
            var landmark = await service.GetLandmarkByIdAsync(id);
            return View(landmark);
        }
    }
}
