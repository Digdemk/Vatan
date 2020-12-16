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
    public class HomeController : BaseController
    {
        private readonly VatanContext _vatancontext;

        public HomeController(VatanContext vatancontext, IMemoryCache memoryCache) : base(vatancontext, memoryCache)
        {
            _vatancontext = vatancontext;
        }
        public IActionResult Index()
        {
            HomeVM charts = new HomeVM();
            charts.Users = _vatancontext.Users.Where(q => q.Isdeleted == false).Take(5).ToList();
            charts.Categories = _vatancontext.Categories.Where(q => q.Isdeleted == false).Take(5).ToList();
            charts.Products = _vatancontext.Products.Where(q => q.Isdeleted == false).Take(5).ToList();
            charts.AdminUsers = _vatancontext.AdminUsers.Where(q => q.Isdeleted == false).Take(5).ToList();
        

            ViewBag.TotalUser = _vatancontext.Users.Count();
            ViewBag.TotalCategory = _vatancontext.Categories.Count();
            ViewBag.TotalProduct = _vatancontext.Products.Count();
            ViewBag.TotalAdminUser = _vatancontext.AdminUsers.Count();
            return View(charts);
        }
    }
}
