using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Yolcu360.Core.Entities;
using Yolcu360.Service.Dtos.Account;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IConfiguration _configuration;

        public AccountsController(UserManager<AppUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            if (await _userManager.FindByEmailAsync(dto.Email)!=null)
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "Username", ErrorMessages.NameTaken(dto.Username));
            }
            AppUser user=new AppUser();
            user.Fullname = dto.Fullname;
            user.Email = dto.Email;
            user.UserName = dto.Username;
            await _userManager.CreateAsync(user, dto.Password);
            await _userManager.AddToRoleAsync(user, "Member");
            return Ok();
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            AppUser user=await _userManager.FindByNameAsync(dto.Username);
            if (user == null)
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "", "Username or Password is incorrect!");
            }
            if (!await _userManager.CheckPasswordAsync(user, dto.Password))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "", "Username or Password is incorrect!");
            }
            List<Claim> claims= new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim(ClaimTypes.Email, user.Email));
            claims.Add(new Claim("Fullname", user.Fullname));
            var roles=_userManager.GetRolesAsync(user).Result.Select(x=>new Claim(ClaimTypes.Role,x)).ToList() ;
            claims.AddRange(roles);

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("JWT:Secret").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var token = new JwtSecurityToken(
                signingCredentials: creds,
                claims: claims,
                expires: DateTime.UtcNow.AddDays(3),
                issuer: _configuration.GetSection("JWT:Issuer").Value,
                audience: _configuration.GetSection("JWT:Audience").Value);
            var tokestr=new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(new { token=tokestr });
        }

    }
}
