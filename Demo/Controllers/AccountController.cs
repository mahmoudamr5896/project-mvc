using Demo.Models;
using Demo.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Identity.Client;

namespace Demo.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Applicationuser> userManager;
        private readonly SignInManager<Applicationuser> signInManage;
        public AccountController(UserManager<Applicationuser> usermodel,SignInManager<Applicationuser> signInManager)
        {
            this.userManager = usermodel;
            this.signInManage = signInManager;
        }
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewmodel newuser)
        {
            if (ModelState.IsValid)
            {
                Applicationuser applicationuser = new Applicationuser();
                applicationuser.UserName = newuser.Username;
                applicationuser.Address = newuser.Address;
                applicationuser.PasswordHash = newuser.Password;
               IdentityResult result = await userManager.CreateAsync(applicationuser,newuser.Password);
                if (result.Succeeded) 
                {
                    // create cookies
                    signInManage.SignInAsync(applicationuser, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var ErrorItem in result.Errors)
                    {
                        ModelState.AddModelError("Password", ErrorItem.Description);

                    }

                }

            }
            else
            {
                return View(newuser);
            }
            return View(newuser);

        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult logout()
        {
            signInManage.SignOutAsync();
            return RedirectToAction("Register");
}
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>  login(Loginuserviewmodel loguser)
        {
            if (ModelState.IsValid)
            {
                // cheek in db
                Applicationuser applicationuser = await userManager.FindByNameAsync(loguser.Username);
                if (applicationuser != null)
                {
                    bool found = await userManager.CheckPasswordAsync(applicationuser, loguser.Password);
                    if (found)
                    {
                        await signInManage.SignInAsync(applicationuser,loguser.RemmberME);
                        return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError("", "USER NMAE AND PASSWORD WRONG");

                }
                return Content("loguser");
            }
            return View(loguser);



        }

        [HttpGet]
        public IActionResult login()
        {
            return View();
        }
    }
    }
