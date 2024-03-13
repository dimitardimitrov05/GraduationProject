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
        public IActionResult Add(Guid id)
        {
            ViewBag.ResortId = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddRoomViewModel model)
        {
            await service.AddAsync(model);

            return RedirectToAction("Info", "Resorts", new { id = model.ResortId });
        }

        //maikatidaeba
        public async Task<IActionResult> Delete(Guid id)
        {
            Guid? resortId = await service.GetResortIdByGivenRoomId(id);
            await service.DeleteRoomAsync(id);

            return RedirectToAction("Info", "Resorts", new { id = resortId });
        }
    }
}