using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data;
using Резервирай_Преживяване.Models.ReservationViewModels;
using Резервирай_Преживяване.Models.ResortViewModels;

namespace Резервирай_Преживяване.Controllers
{
    [Authorize]
    public class ResortsController : Controller
    {
        private readonly IResortService service;
        public ResortsController(IResortService service)
        {
            this.service = service;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = new IndexResortsViewModel();
            model.Resorts = await service.GetAllResortsAsync();
            ViewBag.Cities = new SelectList(await service.GetAllCitiesAsync(), "Id", "Name");
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ResortsByLocation(Guid id)
        {
            var model = new IndexResortsViewModel();
            model.Resorts = await service.ResortsByLocationAsync(id);
            ViewBag.Cities = new SelectList(await service.GetAllCitiesAsync(), "Id", "Name");
            return View("Index", model);
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Add()
        {
            ViewBag.CityId = new SelectList(await service.GetAllCitiesAsync(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Add(AddResortViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await service.AddAsync(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Filter(IndexResortsViewModel model)
        {
            model.Resorts = await service.FilterResortsAsync(model);
            ViewBag.Cities = new SelectList(await service.GetAllCitiesAsync(), "Id", "Name");
            return View("Index", model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> RemoveFilters()
        {
            var model = await service.RemoveFiltersAsync();
            ViewBag.Cities = new SelectList(await service.GetAllCitiesAsync(), "Id", "Name");
            return View("Index", model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Info(Guid id)
        {
            var model = await service.InfoAsync(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return await Task.Run(() => View("Info", model));
        }
    }
}
