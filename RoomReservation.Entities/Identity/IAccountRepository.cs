using Microsoft.AspNetCore.Identity;
using RoomReservation.Api.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Entities.Identity
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(RegisterModel registerModel);
        Task<string> LoginAsync(LoginModel loginModel);
    }
}
