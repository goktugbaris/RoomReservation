using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RoomReservation.Entities
{
    public class Employee:IEntity
    {
        public Employee()
        {
            this.RoomBookings = new HashSet<RoomBooking>();
        }
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public bool IsBusy { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public int OrganizationID { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<RoomBooking> RoomBookings { get; set; }
    }
}
