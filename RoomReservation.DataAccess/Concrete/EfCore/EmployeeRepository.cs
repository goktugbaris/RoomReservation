using RoomReservation.DataAccess.Abstract;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DataAccess.Concrete.EfCore
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public Employee GetByDepartment(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetByOrganization(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
