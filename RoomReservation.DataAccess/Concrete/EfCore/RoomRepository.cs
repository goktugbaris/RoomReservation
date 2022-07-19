using RoomReservation.DataAccess.Abstract;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DataAccess.Concrete.EfCore
{
    public class RoomRepository : IRoomRepository
    {
        public Task<Room> Create(Room entity)
        {
            throw new NotImplementedException();
        }

        public Task<Room> Delete(Room entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Room>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Room> Update(Room entity)
        {
            throw new NotImplementedException();
        }
    }
}
