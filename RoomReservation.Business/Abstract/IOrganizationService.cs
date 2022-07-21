using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Business.Abstract
{
    public interface IOrganizationService
    {
        Task<List<Organization>> GetAll();
        Task<Organization> GetById(int id);
        Task<Organization> Create(Organization entity);
        Task Delete(Organization entity);
        Task Update(Organization entity);
    }
}
