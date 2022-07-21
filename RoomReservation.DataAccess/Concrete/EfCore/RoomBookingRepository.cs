using Microsoft.EntityFrameworkCore;
using RoomReservation.DataAccess.Abstract;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DataAccess.Concrete.EfCore
{
    public class RoomBookingRepository : GenericRepository<RoomBooking>, IRoomBookingRepository
    {
        public RoomBookingRepository(RoomDbContext dbContext) : base(dbContext)
        {
        }
    }
}
