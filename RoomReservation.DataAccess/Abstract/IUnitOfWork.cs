using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DataAccess.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        IDepartmentRepository Departments { get; }
        IEmployeeRepository Employees { get; }
        IOrganizationRepository Organizations { get; }
        IRoomRepository Rooms { get; }
        IRoomBookingRepository RoomBooking{ get; }
        Task<int> SaveAsync();

    }
}
