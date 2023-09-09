using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Yolcu360.Core.Entities;
using Yolcu360.Service.Dtos.Admin;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManeger;
        private readonly IMapper _mapper;

        public AdminsController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManeger, IMapper mapper)
        {
            _roleManager = roleManager;
            _userManeger = userManeger;
            _mapper = mapper;
        }
        //[HttpGet("")]
        //public async Task<IActionResult> CreateRole()
        //{
        //    await _roleManager.CreateAsync(new IdentityRole("Member"));
        //    await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
        //    await _roleManager.CreateAsync(new IdentityRole("Admin"));

        //    return NoContent();
        //}
        //[HttpGet("SuperAdmin")]
        //public async Task<IActionResult> CreateSuperAdmin()
        //{
        //    AppUser superAdmin= new AppUser();
        //    superAdmin.Fullname = "Super Admin";
        //    superAdmin.UserName = "SuperAdmin";
        //    superAdmin.Email = "SuperAdmin@gmail.com";
        //    await _userManeger.CreateAsync(superAdmin,"admin123");
        //    return Ok(superAdmin.Id);
        //}
        //[HttpGet("SetRole")]
        //public async Task<IActionResult> SetRole()
        //{
        //    var superAdmin =await _userManeger.FindByNameAsync("SuperAdmin");
        //    await _userManeger.AddToRoleAsync(superAdmin,"SuperAdmin");
        //    return Ok();
        //}
        [Authorize(Roles = "SuperAdmin")]

        [HttpGet("")]
        public async Task<ActionResult> Get()
        {
            var users = _userManeger.GetUsersInRoleAsync("Admin").Result.ToList();


            foreach (AppUser user in users)
            {
                var roles =await _userManeger.GetRolesAsync(user);
                foreach (var role in roles)
                {
                    user.Roles.Add(role);
                }
            }
            var datas = _mapper.Map<List<AdminGetAllDto>>(users);

            return Ok(datas);
        }
        [Authorize(Roles = "SuperAdmin")]

        [HttpPost("")]
        public async Task<ActionResult> Create(AdminCreateDto dto)
        {
            AppUser user=_mapper.Map<AppUser>(dto);
            if (dto.Password==dto.AgainPassword)
            {
                await _userManeger.CreateAsync(user, dto.Password);
            }
            await _userManeger.UpdateAsync(user);
            await _userManeger.AddToRoleAsync(user, "Admin");
            return Ok();
        }
        [Authorize(Roles = "SuperAdmin")]

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            var user =await _userManeger.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            var roles = await _userManeger.GetRolesAsync(user);

            foreach (string role in roles)
            {
                user.Roles.Add(role);
            }

            var datas = _mapper.Map<AdminGetAllDto>(user);

            return Ok(datas);
        }
        [Authorize(Roles = "SuperAdmin")]

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var user = await _userManeger.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            await _userManeger.DeleteAsync(user);
            await _userManeger.UpdateAsync(user);
            return NoContent();
        }
        [Authorize(Roles = "SuperAdmin")]

        [HttpPut("{id}")]
        public async Task<ActionResult> Edit(string id,AdminEditDto dto)
        {
            var user = await _userManeger.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            user.Fullname = dto.Fullname;
            user.UserName = dto.UserName;
            user.PhoneNumber = dto.PhoneNumber;
            user.Email = dto.PhoneNumber;

            if (dto.Password!=null && dto.Password==dto.AgainPassword)
            {
                var token = await _userManeger.GeneratePasswordResetTokenAsync(user);
                await _userManeger.ResetPasswordAsync(user, token, dto.Password);
            }

            await _userManeger.UpdateAsync(user);

            return NoContent();
        }
    }
}
