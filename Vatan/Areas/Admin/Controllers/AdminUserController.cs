using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IActionResult Register()
        {
            AdminUserVM model = new AdminUserVM();
            

            return View(model);


        }

    }
}
