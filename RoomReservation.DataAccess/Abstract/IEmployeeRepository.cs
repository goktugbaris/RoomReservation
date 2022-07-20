using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DataAccess.Abstract
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
        Employee GetByOrganization(Employee employee);
        Employee GetByDepartment(Employee employee);
    }
}
