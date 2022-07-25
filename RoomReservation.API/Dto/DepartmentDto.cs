using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomReservation.Api.Dto
{
    public class DepartmentDto
    {
        public int DeparmentId { get; set; }
        public string DepartmentName { get; set; }
        public int OrganizationID { get; set; }
    }
}
