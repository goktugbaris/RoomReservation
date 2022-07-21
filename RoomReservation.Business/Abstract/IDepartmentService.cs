using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Business.Abstract
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAll();
        Task<Department> GetById(int id);
        Task<Department> Create(Department entity);
        Task Delete(Department entity);
        Task Update(Department entity);
    }
}
