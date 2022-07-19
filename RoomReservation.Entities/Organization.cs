using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Entities
{
    public class Organization
    {
        public Organization()
        {
            this.Departments = new HashSet<Department>();
        }
        [Key]
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
