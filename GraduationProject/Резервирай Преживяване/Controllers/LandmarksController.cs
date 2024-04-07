using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Резервирай_Преживяване.Contracts;

namespace Резервирай_Преживяване.Controllers
{
    [Authorize]
    public class LandmarksController : Controller
    {
        private readonly ILandmarkService service;

        public LandmarksController(ILandmarkService service)
        {
            this.service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var landmarks = await service.GetAllLandmarksAsync();
            return View(landmarks);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> EachLandmark(Guid id)
        {
            try
            {
                var landmark = await service.GetLandmarkByIdAsync(id);
                return View(landmark);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View("Index");
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> LandmarksByLocation(Guid id)
        {
            try
            {
                var landmarks = await service.GetLandmarksByLocation(id);
                return View("Index", landmarks);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View("Index");
            }
        }
    }
}
