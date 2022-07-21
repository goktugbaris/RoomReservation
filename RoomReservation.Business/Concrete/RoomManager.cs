using RoomReservation.Business.Abstract;
using RoomReservation.DataAccess.Abstract;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Business.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IUnitOfWork _unitofwork;
        public RoomManager(IUnitOfWork unitOfWork)
        {
            _unitofwork = unitOfWork;
        }
        public async Task<Room> Create(Room entity)
        {
            await _unitofwork.Rooms.Create(entity);
            await _unitofwork.SaveAsync();
            return entity;
        }

        public Task Delete(int id)
        {
            return _unitofwork.Rooms.Delete(id);
        }

        public async Task<List<Room>> GetAll()
        {
            return await _unitofwork.Rooms.GetAll();
        }

        public async Task<Room> GetById(int id)
        {
            return await _unitofwork.Rooms.GetById(id);
        }

        public List<Room> GetHomePage()
        {
            return _unitofwork.Rooms.GetHomePage();
        }

        public async Task Update(Room entity)
        {
            await _unitofwork.Rooms.Update(entity);
            await _unitofwork.SaveAsync();
        }
    }
}
