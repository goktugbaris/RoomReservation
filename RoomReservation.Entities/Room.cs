using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Entities
{
    public class Room
    {
        public Room()
        {
            this.RoomBookings = new HashSet<RoomBooking>();
        }
        [Key]
        public int RoomId { get; set; }
        public int Capacity { get; set; }
        public int Floor { get; set; }
        public string RoomInfo { get; set; }
        public bool IsAvaliable { get; set; }
        public virtual ICollection<RoomBooking> RoomBookings{ get; set; }
    }
}
