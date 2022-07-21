using FluentValidation;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Business.Validators
{
    public class RoomValidator:AbstractValidator<Room>
    {
        public RoomValidator()
        {
            RuleFor(x => x.RoomId).NotNull().NotEmpty();
            RuleFor(x => x.Capacity).GreaterThan(0).NotEmpty().InclusiveBetween(1,50);
            RuleFor(x => x.Floor).GreaterThan(0).NotEmpty().InclusiveBetween(1,10);
            RuleFor(x => x.IsAvaliable).NotEmpty();
            RuleFor(x => x.IsHome).NotEmpty();
            RuleFor(x => x.RoomInfo).NotEmpty();
        }
        
    }
}
