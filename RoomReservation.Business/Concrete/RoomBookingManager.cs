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
    public class RoomBookingManager : IRoomBookingService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomBookingManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<RoomBooking> Create(RoomBooking entity)
        {
            await _unitOfWork.RoomBooking.Create(entity);
            await _unitOfWork.SaveAsync();
            return entity;
        }

        public async Task Delete(RoomBooking entity)
        {
            await _unitOfWork.RoomBooking.Delete(entity);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<RoomBooking>> GetAll()
        {
            return await _unitOfWork.RoomBooking.GetAll();
        }

        public async Task<RoomBooking> GetById(int id)
        {
            return await _unitOfWork.RoomBooking.GetById(id);
        }

        public async Task Update(RoomBooking entity)
        {
            await _unitOfWork.RoomBooking.Update(entity);
            await _unitOfWork.SaveAsync();
        }
    }
}
