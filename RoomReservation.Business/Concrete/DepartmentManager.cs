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
    public class DepartmentManager : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public async Task<Department> Create(Department entity)
        {
            await _unitOfWork.Departments.Create(entity);
            await _unitOfWork.SaveAsync();
            return entity;
        }

        public async Task Delete(Department entity)
        {
            await _unitOfWork.Departments.Delete(entity);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<Department>> GetAll()
        {
            return await _unitOfWork.Departments.GetAll();
        }

        public async Task<Department> GetById(int id)
        {
            return await _unitOfWork.Departments.GetById(id);
        }

        public async Task Update(Department entity)
        {
            await _unitOfWork.Departments.Update(entity);
            await _unitOfWork.SaveAsync();
        }
    }
}
