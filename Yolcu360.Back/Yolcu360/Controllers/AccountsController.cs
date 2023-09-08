using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Yolcu360.Core.Entities;
using Yolcu360.Data;
using Yolcu360.Service.Dtos.Account;
using Yolcu360.Service.Exceptions;
using Yolcu360.Service.Helpers;
using Yolcu360.Service.Mail;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IMailService _mailService;
        private readonly Yolcu360DbContext _context;
        private readonly IMapper _mapper;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountsController(UserManager<AppUser> userManager, IConfiguration configuration, IMailService mailService, Yolcu360DbContext context, IMapper mapper, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _configuration = configuration;
            _mailService = mailService;
            _context = context;
            _mapper = mapper;
            _signInManager = signInManager;
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

            int code=new Random().Next(1000,9999);
            user.MailConfirmCode= code;
            await _userManager.UpdateAsync(user);
            await _mailService.SendEmailAsync(new MailRequest()
            {
                ToEmail = user.Email,
                Subject = "Mail Configuration!!!",
                Body = $"<h3>Salam</h3><h4>Sizin təsdiq kodunuz</h4><h1>{code}</h1>"
            });

            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim(ClaimTypes.Email, user.Email));
            claims.Add(new Claim("Fullname", user.Fullname));
            var roles = (_userManager.GetRolesAsync(user).Result).Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            claims.AddRange(roles);

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("JWT:Secret").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var token = new JwtSecurityToken(
                signingCredentials: creds,
                claims: claims,
                expires: DateTime.UtcNow.AddDays(3),
                issuer: _configuration.GetSection("JWT:Issuer").Value,
                audience: _configuration.GetSection("JWT:Audience").Value
                );
            var tokestr = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(new { token = tokestr });
        }
        [Authorize(Roles = "Member")]
        [HttpPost("MailConfirm")]
        public async Task<IActionResult> MailConfirm(MailConfirmDto dto)
        {
            AppUser user =await _userManager.FindByNameAsync(User?.Identity?.Name);
            if (user==null)
                return NotFound();
            if (user.MailConfirmCode!=dto.ConfirmCode)
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "ConfirmCode", "Code is not true!");
            }
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            await _userManager.ConfirmEmailAsync(user, token);
            return NoContent();
        }
        [Authorize(Roles = "Member")]
        [HttpPost("SendAgain")]
        public async Task<IActionResult> SendAgain(MailConfirmDto dto)
        {
            AppUser user = await _userManager.FindByNameAsync(User?.Identity?.Name);
            if (user == null)
                return NotFound();
            int code = new Random().Next(1, 9999);
            user.MailConfirmCode = code;
            await _userManager.UpdateAsync(user);
            await _mailService.SendEmailAsync(new MailRequest()
            {
                ToEmail = user.Email,
                Subject = "Mail Configuration!!!",
                Body = $"<h3>Salam</h3><h4>Sizin təsdiq kodunuz</h4><h1>{code}</h1>"
            });
            return NoContent();
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
            var roles=(_userManager.GetRolesAsync(user).Result).Select(x=>new Claim(ClaimTypes.Role,x)).ToList() ;
            claims.AddRange(roles);

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("JWT:Secret").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var token = new JwtSecurityToken(
                signingCredentials: creds,
                claims: claims,
                expires: DateTime.UtcNow.AddDays(3),
                issuer: _configuration.GetSection("JWT:Issuer").Value,
                audience: _configuration.GetSection("JWT:Audience").Value
                );
            var tokestr=new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(new { token=tokestr });
        }
        [HttpPost("AdminLogin")]
        public async Task<IActionResult> AdminLogin(LoginDto dto)
        {
            AppUser user = await _userManager.FindByNameAsync(dto.Username);
            if (user == null)
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "", "Username or Password is incorrect!");
            }
            if (!await _userManager.CheckPasswordAsync(user, dto.Password))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "", "Username or Password is incorrect!");
            }
            if (!_userManager.IsInRoleAsync(user,"Admin").Result && !_userManager.IsInRoleAsync(user,"SuperAdmin").Result)
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "", "You are not admin!");
            }
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim(ClaimTypes.Email, user.Email));
            claims.Add(new Claim("Fullname", user.Fullname));
            var roles = (_userManager.GetRolesAsync(user).Result).Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            claims.AddRange(roles);

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("JWT:Secret").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var token = new JwtSecurityToken(
                signingCredentials: creds,
                claims: claims,
                expires: DateTime.UtcNow.AddDays(3),
                issuer: _configuration.GetSection("JWT:Issuer").Value,
                audience: _configuration.GetSection("JWT:Audience").Value
                );
            var tokestr = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(new { token = tokestr });
        }
        [Authorize(Roles = "Member")]
        [HttpPost("ChangePassword")]
        public async Task<ActionResult> ChangePassword(ChangePasswordDto dto)
        {
            AppUser user = await _userManager.FindByIdAsync(User?.FindFirstValue(ClaimTypes.NameIdentifier));
            if (!await _userManager.CheckPasswordAsync(user,dto.Current))
            {
                return BadRequest();
            }
            if (dto.NewPassword==dto.AgainPassword)
            {
                await _userManager.ChangePasswordAsync(user, dto.Current, dto.NewPassword);
                await _userManager.UpdateAsync(user);
            }
            else
            {
                return BadRequest();
            }
            return NoContent();
        }
        [Authorize(Roles = "Member")]
        [HttpGet("Profile")]
        public  ActionResult<ProfileDto> Profile()
        {
            AppUser user = _context.Users.Include(x => x.Rents).ThenInclude(x => x.Car).FirstOrDefault(x => x.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));
            if (user==null)
            {
                return NotFound();
            }
            return _mapper.Map<ProfileDto>(user);
        }
        [Authorize(Roles = "Member")]
        [HttpPut("ChangeInfo")]
        public async Task<ActionResult> ChangeInfo(ChangeInfoDto dto)
        {
            AppUser user = await _userManager.FindByIdAsync(User?.FindFirstValue(ClaimTypes.NameIdentifier));
            if (user==null)
            {
                return NotFound();
            }
            user.PhoneNumber = dto.Phone;
            user.Address= dto.Address;
            user.Birthday= dto.Birthday;
            user.Pasport=dto.Pasport;
            user.Fullname=dto.Fullname;

            if(dto.Username!=null & user.UserName !=dto.Username)
            {
                user.UserName= dto.Username;
            }
            if (dto.Phone != null & user.PhoneNumber != dto.Phone)
            {
                user.PhoneNumber = dto.Phone;
            }
            await _userManager.UpdateAsync(user);
            return NoContent();
        }
        [HttpDelete("DeleteUser/{id}")]
        public async Task<ActionResult> DeleteUser(string id)
        {
            AppUser user =await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            try
            {
                await _userManager.DeleteAsync(user);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.InnerException?.Message);
            }
            return NoContent();
        }
        [HttpPost("ForgetPassword/{email}")]
        public async Task<ActionResult> ForgetPassword(string email)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);
            if (user==null)
            {
                return BadRequest();
            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            byte[] tokenBytes = Encoding.UTF8.GetBytes(token);
            token = WebEncoders.Base64UrlEncode(tokenBytes);

            var url = "http://localhost:3000/resetpasword/" + user.Id + "/" + token;
            await _mailService.SendEmailAsync(new MailRequest()
            {
                ToEmail = email,
                Subject = "Forget Password!!!",
                Body = $"<h3>Salam hörmətli istifadəçi,</h3><br/><h4></h4>Şifrənizi dəyişmək üçün zəhmət olmasa bu linkə <a href={url}>klikləyin</h1>."
            });
            return NoContent();

        }
        [HttpPost("ResetPassword")]
        public async Task<ActionResult> ResetPassword([FromBody]ResetPasswordDto dto)
        {
            AppUser user = await _userManager.FindByIdAsync(dto.UserId);
            if (user == null)
            {
                return BadRequest();
            }
            byte[] byteToken = WebEncoders.Base64UrlDecode(dto.Token);
            var tokenmn = Encoding.UTF8.GetString(byteToken);

            if (dto.NewPassword!=dto.AgainPassword)
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "Wrong Password");
            }

            var result = await _userManager.ResetPasswordAsync(user, tokenmn, dto.NewPassword);

            if (!result.Succeeded)
            {
                List<RestExceptionErrorItem> Errors = new List<RestExceptionErrorItem>();
                foreach (var error in result.Errors)
                {
                    RestExceptionErrorItem resterror = new RestExceptionErrorItem(error.Code,error.Description);
                    Errors.Add(resterror);

                }
                throw new RestException(System.Net.HttpStatusCode.BadRequest,Errors);
            }

            return NoContent();

        }


    }
}
