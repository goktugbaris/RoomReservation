using System;
using System.ComponentModel.DataAnnotations;

namespace RoomReservation.Entities
{
    public class Employee:IEntity
    {
        [Key]
        public int RegistryNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
    }
}
