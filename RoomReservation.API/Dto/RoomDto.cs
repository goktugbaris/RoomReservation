using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomReservation.Api.Dto
{
    public class RoomDto
    {
        public int RoomId { get; set; }
        public int Capacity { get; set; }
        public int Floor { get; set; }
        public string RoomInfo { get; set; }
        public bool IsAvaliable { get; set; }
        public bool IsHome { get; set; }
    }
}
