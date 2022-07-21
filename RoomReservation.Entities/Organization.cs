using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Entities
{
    public class Organization:IEntity
    {
        public Organization()
        {
            this.Departments = new HashSet<Department>();
            this.Employees = new HashSet<Employee>();
        }
        [Key]
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
