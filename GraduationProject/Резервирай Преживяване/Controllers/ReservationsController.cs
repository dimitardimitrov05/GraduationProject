using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Data.Account;
using Резервирай_Преживяване.Models.ReservationViewModels;
using Резервирай_Преживяване.Models.RoomViewModels;

namespace Резервирай_Преживяване.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly IReservationService reservationService;
        private readonly IRoomService roomService;
        private readonly UserManager<User> userManager;

        public ReservationsController(IReservationService reservationService, IRoomService roomService, UserManager<User> userManager)
        {
            this.reservationService = reservationService;
            this.roomService = roomService;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid id)
        {
            var model = await roomService.GetAllRoomsByHotelAsync(id);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add(Guid id)
        {
            var model = new AddReservationViewModel();
            model.Room = await roomService.RoomToReservateAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddReservationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.GetUserAsync(this.User);
            await reservationService.AddReservationAsync(model, user);
            return RedirectToAction("Confirm");
        }

        [HttpGet]
        public IActionResult Confirm()
        {
            return View();
        }
    }
}
