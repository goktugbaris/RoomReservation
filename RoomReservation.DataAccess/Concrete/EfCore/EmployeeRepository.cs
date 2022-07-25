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
        //public List<Employee> GetByDepartment(int id)
        //{
        //    var employees = _dbContext.Employees.Include(i => i.Department).ToList();
        //    return employees; 
        //}
    }
}
