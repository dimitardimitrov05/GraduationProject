using Microsoft.AspNetCore.Mvc;
using Резервирай_Преживяване.Contracts;
using Резервирай_Преживяване.Models.ReservationViewModels;
using Резервирай_Преживяване.Models.RoomViewModels;

namespace Резервирай_Преживяване.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly IReservationService reservationService;
        private readonly IRoomService roomService;

        public ReservationsController(IReservationService reservationService, IRoomService roomService)
        {
            this.reservationService = reservationService;
            this.roomService = roomService;
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
    }
}
