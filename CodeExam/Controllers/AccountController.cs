using CodeExam.Helpers;
using CodeExam.Models;
using CodeExam.ModelViews.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeExam.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterVm registerVm)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("","Please enter");
                return View();
            }
            
            return View();
        }

        public async Task CreateRole()
        {
            foreach(var item in Enum.GetValues(typeof(RoleEnum)))
            {
                if(await _roleManager.RoleExistsAsync(item.ToString()))
                {
                    await _roleManager.CreateAsync(new IdentityRole()
                    {
                        Name = item.ToString()
                    });
                }
            }
        }
    }
}
