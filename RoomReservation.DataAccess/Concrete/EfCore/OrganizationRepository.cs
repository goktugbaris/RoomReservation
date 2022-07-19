using RoomReservation.DataAccess.Abstract;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DataAccess.Concrete.EfCore
{
    public class OrganizationRepository : IOrganizationRepository
    {
        public Task<Organization> Create(Organization entity)
        {
            throw new NotImplementedException();
        }

        public Task<Organization> Delete(Organization entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Organization>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Organization> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Organization> Update(Organization entity)
        {
            throw new NotImplementedException();
        }
    }
}
