using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Vatan.Areas.Admin.Models.ORM.Context;
using Vatan.Areas.Admin.Models.ORM.Entities;
using Vatan.Areas.Admin.Models.VM;

namespace Vatan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly VatanContext _vatancontext;

        public LoginController(VatanContext vatancontext)
        {
            _vatancontext = vatancontext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginVM model)
        {

            if (ModelState.IsValid)
            {
                AdminUser adminuser = _vatancontext.AdminUsers.FirstOrDefault(x => x.EMail == model.EMail && x.Password == model.Password);
                if (adminuser != null)
                {

                    var claims = new List<Claim>
                 {
                new Claim(ClaimTypes.Name, model.EMail),

                 };

                    var userIdentity = new ClaimsIdentity(claims, "login");

                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    await HttpContext.SignInAsync(principal);

                    adminuser.Lastlogindate = DateTime.Now;

                    _vatancontext.SaveChanges();

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.error = "Kullanıcı adı veya şifre hatalı!";
                    return View();
                }
            }
            else
            {

                return View();
            }

        }


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }

    }
}
