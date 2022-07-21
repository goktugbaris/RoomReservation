using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Business.Abstract
{
    public interface IRoomBookingService
    {
        Task<List<RoomBooking>> GetAll();
        Task<RoomBooking> GetById(int id);
        Task<RoomBooking> Create(RoomBooking entity);
        Task Delete(RoomBooking entity);
        Task Update(RoomBooking entity);
    }
}
