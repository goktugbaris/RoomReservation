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
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        private readonly RoomDbContext _dbContext;
        public RoomRepository(RoomDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        private RoomDbContext RoomDbContext
        {
            get { return _dbContext; }
        }

        public List<Room> GetHomePage()
        {
            return _dbContext.Rooms.Where(i => i.IsAvaliable && i.IsHome).ToList();
        }
    }
}
