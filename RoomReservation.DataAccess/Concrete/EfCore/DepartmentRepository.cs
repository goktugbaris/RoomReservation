using RoomReservation.DataAccess.Abstract;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DataAccess.Concrete.EfCore
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public Task<Department> Create(Department entity)
        {
            throw new NotImplementedException();
        }

        public Task<Department> Delete(Department entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Department>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Department> Update(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
