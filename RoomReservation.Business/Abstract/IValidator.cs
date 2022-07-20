using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Business.Abstract
{
    public interface IValidator<T>
    {
        public string ErrorMessage { get; set; }
        public bool Validation(T entity);
    }
}
