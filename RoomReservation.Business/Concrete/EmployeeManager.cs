using RoomReservation.Business.Abstract;
using RoomReservation.DataAccess.Abstract;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Employee> Create(Employee entity)
        {
            await _unitOfWork.Employees.Create(entity);
            await _unitOfWork.SaveAsync();
            return entity;
        }

        public async Task Delete(Employee entity)
        {
            await _unitOfWork.Employees.Delete(entity);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<Employee>> GetAll()
        {
            return await _unitOfWork.Employees.GetAll();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _unitOfWork.Employees.GetById(id);
        }

        public async Task Update(Employee entity)
        {
            await _unitOfWork.Employees.Update(entity);
            await _unitOfWork.SaveAsync();
        }
    }
}
