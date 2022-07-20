using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Entities
{
    public class Department:IEntity
    {
        public Department()
        {
            this.Employees = new HashSet<Employee>();
        }
        [Key]
        public int DeparmentId { get; set; }
        public string DepartmentName { get; set; }
        public int OrganizationID { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
