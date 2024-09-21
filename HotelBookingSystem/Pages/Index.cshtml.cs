using HotelBookingSystem.Repositories.Interfaces;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelBookingSystem.Pages
{
    public class IndexModel : PageModel
    {
        public List<Room> Rooms { get; set; }


        private readonly IRoomRepository _roomRepository;

        public IndexModel(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public void OnGet()
        {
            Rooms = _roomRepository.GetAll().ToList();
        }
    }
}
