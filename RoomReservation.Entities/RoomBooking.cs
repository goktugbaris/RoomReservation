﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Entities
{
    public class RoomBooking:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime Date { get; set; }
        public int RegistryNo { get; set; }
        public virtual Employee Employee { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public object DateTime { get; set; }
    }
}
