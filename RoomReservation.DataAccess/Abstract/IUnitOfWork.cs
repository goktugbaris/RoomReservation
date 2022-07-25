using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DataAccess.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        IDepartmentRepository Department { get; }
        IEmployeeRepository Employee { get; }
        IOrganizationRepository Organization { get; }
        IRoomRepository Room { get; }
        IRoomBookingRepository RoomBooking{ get; }
        Task<int> SaveAsync();

    }
}
