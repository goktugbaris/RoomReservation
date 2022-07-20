using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DataAccess.Abstract
{
    public interface IRoomRepository:IGenericRepository<Room>
    {
        Room GetRoomInfo(string info);
    }
}
