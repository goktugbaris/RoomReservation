using RoomReservation.DataAccess.Abstract;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DataAccess.Concrete.EfCore
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<Employee> Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
