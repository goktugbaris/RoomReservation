using Microsoft.EntityFrameworkCore;
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
        private readonly RoomDbContext _dbContext;
        public EmployeeRepository(RoomDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        private RoomDbContext RoomDbContext
        {
            get { return _dbContext; }
        }

        //public Employee GetByDepartment(string fname)
        //{
        //    var employee = _dbContext
        //            .Employees
        //            .Where(i => i.IsBusy)
        //            .AsQueryable();
        //    if(!string.IsNullOrEmpty(fname))
        //    {
        //        employee = employee.Include(i=>i.RoomBookings)
        //                           .ThenInclude(i=> i.Department)
        //                           .Where(i=> i.RoomBookings.Any(j=> j.Department))
        //    }
        //}

        //public Employee GetByOrganization(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
