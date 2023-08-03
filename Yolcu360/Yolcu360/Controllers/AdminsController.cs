using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Yolcu360.Core.Entities;

namespace Yolcu360.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManeger;

        public AdminsController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManeger)
        {
            _roleManager = roleManager;
            _userManeger = userManeger;
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
    }
}
