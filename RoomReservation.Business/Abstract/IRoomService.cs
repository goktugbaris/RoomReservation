using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Business.Abstract
{
    public interface IRoomService
    {
        Task<Room> GetById(int id);
        Task<List<Room>> GetAll();
        Task<Room> Create(Room entity);
        Task Update(Room entity);
        Task Delete(Room entity);
        List<Room> GetHomePage();
    }
}
