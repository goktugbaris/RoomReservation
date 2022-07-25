using AutoMapper.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using RoomReservation.Api.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private Microsoft.Extensions.Configuration.IConfiguration _config;
        public LoginController(Microsoft.Extensions.Configuration.IConfiguration config)
        {
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] UserLogin userLogin)
        {
            var user = Authenticate(userLogin);
            if(user != null)
            {
                var token = Generate(user);
                return Ok(token);
            }
            return NotFound("User Not Found");
        }

        private string Generate(UserModel user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Username),
                new Claim(ClaimTypes.Email, user.EmailAddress),
                new Claim(ClaimTypes.GivenName, user.GivenName),
                new Claim(ClaimTypes.Surname, user.Surname),
                new Claim(ClaimTypes.Role, user.Role),
            };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"], 
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credential);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private UserModel Authenticate(UserLogin userLogin)
        {
            var currentUser = UserConstants.Users.FirstOrDefault(i => i.Username.ToLower() == userLogin.Username.ToLower() && i.Password == userLogin.Password);

            if(currentUser != null)
            {
                return currentUser;
            }
            return null;
        }
    }

}
