using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Models.RoomViewModels;

namespace Резервирай_Преживяване.Controllers
{
    public class RoomsController : Controller
    {
        private readonly IRoomService service;

        public RoomsController(IRoomService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ViewBag.ResortId = new SelectList(await service.GetAllResortsAsync(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddRoomViewModel model)
        {
            await service.AddAsync(model);
            return RedirectToAction("Info", model.ResortId);
        }
    }
}
