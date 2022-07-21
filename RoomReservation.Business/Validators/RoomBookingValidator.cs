using FluentValidation;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Business.Validators
{
    public class RoomBookingValidator: AbstractValidator<RoomBooking>
    {
        public RoomBookingValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().Length(1,10);
            RuleFor(x => x.LastName).NotEmpty().Length(1, 10);
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Date).NotEmpty().LessThan(i => DateTime.Now);
            RuleFor(x => x.StartTime).NotEmpty();
            RuleFor(x => x.EndTime).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.EmployeeID).NotEmpty();
        }
    }
}
