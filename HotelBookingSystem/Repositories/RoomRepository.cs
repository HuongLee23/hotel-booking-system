using HotelBookingSystem.Repositories.Interfaces;
using Infrastructure.Models;

namespace HotelBookingSystem.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly Booking_hotelContext _context;

        public RoomRepository(Booking_hotelContext context)
        {
            _context = context;
        }

        public IEnumerable<Room> GetAll()
        {
            var rooms = _context.Rooms;
            return rooms;
        }

        public void Add(Room room)
        {
            _context.Rooms.Add(room);
        }

        public void Edit(Room room)
        {
            var roomEdit = _context.Rooms.Find(room.RoomId);
            if (roomEdit != null)
            {
                room.RoomNumber = room.RoomNumber;
                room.PricePerNight = roomEdit.PricePerNight;
                room.Description = roomEdit.Description;
            }
        }

        public void Remove(int roomId)
        {
            var room = _context.Rooms.Find(roomId);

            if (room != null)
            {
                _context.Rooms.Remove(room);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
