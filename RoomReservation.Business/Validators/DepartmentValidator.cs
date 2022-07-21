using FluentValidation;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Business.Validators
{
    public class DepartmentValidator: AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(x => x.DeparmentId).NotEmpty();
            RuleFor(x => x.OrganizationID).NotEmpty().GreaterThan(0);
            RuleFor(x => x.DepartmentName).NotEmpty().Length(40);
        }
    }
}
