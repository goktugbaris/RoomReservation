using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DataAccess.Abstract
{
    public interface IGenericRepository<T>
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task<T> Create(T entity);
        Task Update(T entity, int id);
        Task Delete(int id);
    }
}
