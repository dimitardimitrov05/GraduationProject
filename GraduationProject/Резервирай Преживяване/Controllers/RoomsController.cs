using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Models.RoomViewModels;

namespace Резервирай_Преживяване.Controllers
{
    [Authorize]
    public class RoomsController : Controller
    {
        private readonly IRoomService service;

        public RoomsController(IRoomService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IActionResult Add(Guid id)
        {
            ViewBag.ResortId = id;
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Add(AddRoomViewModel model)
        {
            await service.AddAsync(model);

            return RedirectToAction("Info", "Resorts", new { id = model.ResortId });
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(Guid id)
        {
            Guid? resortId = await service.GetResortIdByGivenRoomId(id);
            await service.DeleteRoomAsync(id);

            return RedirectToAction("Info", "Resorts", new { id = resortId });
        }
    }
}