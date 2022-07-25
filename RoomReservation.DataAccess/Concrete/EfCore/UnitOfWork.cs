using RoomReservation.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DataAccess.Concrete.EfCore
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly RoomDbContext _context;
        public UnitOfWork(RoomDbContext context)
        {
            _context = context;
        }
        private DepartmentRepository _departmentRepository;
        private EmployeeRepository _employeeRepository;
        private OrganizationRepository _organizationRepository;
        private RoomRepository _roomRepository;
        private RoomBookingRepository _roomBookingRepository;

        public IDepartmentRepository Department => _departmentRepository = _departmentRepository ?? new DepartmentRepository(_context);
        public IEmployeeRepository Employee => _employeeRepository = _employeeRepository ?? new EmployeeRepository(_context);
        public IOrganizationRepository Organization => _organizationRepository = _organizationRepository ?? new OrganizationRepository(_context);
        public IRoomRepository Room => _roomRepository = _roomRepository ?? new RoomRepository(_context);

        public IRoomBookingRepository RoomBooking => _roomBookingRepository ?? new RoomBookingRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
