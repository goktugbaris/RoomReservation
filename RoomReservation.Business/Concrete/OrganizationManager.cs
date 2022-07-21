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
    public class OrganizationManager : IOrganizationService
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrganizationManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Organization> Create(Organization entity)
        {
            await _unitOfWork.Organizations.Create(entity);
            await _unitOfWork.SaveAsync();
            return entity;
        }

        public async Task Delete(Organization entity)
        {
            await _unitOfWork.Organizations.Delete(entity);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<Organization>> GetAll()
        {
            return await _unitOfWork.Organizations.GetAll();
        }

        public async Task<Organization> GetById(int id)
        {
            return await _unitOfWork.Organizations.GetById(id);
        }

        public async Task Update(Organization entity)
        {
            await _unitOfWork.Organizations.Update(entity);
        }
    }
}
