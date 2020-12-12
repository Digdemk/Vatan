using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Models.ORM.Context;
using Vatan.Models.VM;

namespace Vatan.Controllers
{
    public class HomeController : Controller
    {
        private readonly VatanContext _vatancontext;

        public HomeController(VatanContext vatanContext)
        {
            _vatancontext = vatanContext;
        }
        public IActionResult Index()
        {
            HomeVM charts = new HomeVM();
            charts.Users = _vatancontext.Users.Where(q => q.Isdeleted == false).Take(5).ToList();
            charts.Categories = _vatancontext.Categories.Where(q => q.Isdeleted == false).Take(5).ToList();
            charts.Products = _vatancontext.Products.Where(q => q.Isdeleted == false).Take(5).ToList();
        

            ViewBag.TotalUser = _vatancontext.Users.Count();
            ViewBag.TotalCategory = _vatancontext.Categories.Count();
            ViewBag.TotalProduct = _vatancontext.Products.Count();
            return View(charts);
        }
    }
}
