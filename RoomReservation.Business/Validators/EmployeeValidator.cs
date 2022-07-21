using FluentValidation;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Business.Validators
{
    public class EmployeeValidator: AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().Length(1, 10);
            RuleFor(x => x.LastName).NotEmpty().Length(1, 10);
            RuleFor(x => x.Email).EmailAddress().NotEmpty();
            RuleFor(x => x.IsBusy).NotEmpty();
            RuleFor(x => x.RegistryNo).NotEmpty().WithMessage("Sicil numarası boş olamaz.");
            RuleFor(x => x.DepartmentID).NotEmpty();
        }
    }
}
