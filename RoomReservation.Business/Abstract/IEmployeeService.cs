using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Business.Abstract
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAll();
        Task<Employee> GetById(int id);
        Task<Employee> Create(Employee entity);
        Task Delete(Employee entity);
        Task Update(Employee entity);
        List<Employee> GetByOrganization(int id);
        List<Employee> GetByDepartment(int id);
    }
}
