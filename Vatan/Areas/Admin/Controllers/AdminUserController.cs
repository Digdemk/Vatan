using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Areas.Admin.Models.Attributes;
using Vatan.Areas.Admin.Models.Enums;
using Vatan.Areas.Admin.Models.ORM.Context;
using Vatan.Areas.Admin.Models.ORM.Entities;
using Vatan.Areas.Admin.Models.VM;

namespace Vatan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminUserController : BaseController
    {
        private readonly VatanContext _vatancontext;

        public AdminUserController(VatanContext vatancontext, IMemoryCache memoryCache) : base(vatancontext, memoryCache)
        {
            _vatancontext = vatancontext;
        }

        [RoleControl(EnumRoles.AdminList)]

        public IActionResult Index()
        {
            List<AdminUserVM> model = _vatancontext.AdminUsers.Where(q => q.Isdeleted == false).Select(q => new AdminUserVM()
            {
                ID = q.ID,
                EMail = q.EMail,
                Name = q.Name,
                Surname = q.Surname,
                Password = q.Password,
                Lastlogindate = q.Lastlogindate,

            }).ToList();

            return View(model);
        }

        [RoleControl(EnumRoles.AdminAdd)]
        public IActionResult Add()
        {

            return View();

        }



        [HttpPost]
        public IActionResult Add(AdminUserVM model)
        {
            if (ModelState.IsValid)
            {
                AdminUser adminUser = new AdminUser();

                adminUser.EMail = model.EMail;
                adminUser.Name = model.Name;
                adminUser.Surname = model.Surname;
                adminUser.Password = model.Password;



                _vatancontext.AdminUsers.Add(adminUser);
                _vatancontext.SaveChanges();
            }
            else
            {
                return View();
            }

            return RedirectToAction("Index", "Login");
        }

    }
}
