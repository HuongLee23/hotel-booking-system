using Infrastructure.Models;

namespace HotelBookingSystem.Repositories.Interfaces
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetAll();

        void Add(Room room);

        void Edit(Room room);

        void Remove(int roomId);

        void Save();
    }
}
