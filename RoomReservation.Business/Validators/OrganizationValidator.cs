using FluentValidation;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Business.Validators
{
    public class OrganizationValidator: AbstractValidator<Organization>
    {
        public OrganizationValidator()
        {
            RuleFor(x => x.OrganizationId).NotEmpty();
            RuleFor(x => x.OrganizationName).NotEmpty();
        }
    }
}
