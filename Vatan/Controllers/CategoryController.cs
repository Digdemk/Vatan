using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Models.ORM.Context;
using Vatan.Models.ORM.Entities;

namespace Vatan.Controllers
{
    public class CategoryController : Controller
    {
        private readonly VatanContext _vatancontext;

        public CategoryController(VatanContext vatanContext)
        {
            _vatancontext = vatanContext;
        }
        public IActionResult Index()
        {
            List<Category> model = _vatancontext.Categories.ToList();
            return View(model);
            
        }

        public IActionResult Add()
        {
            return View();
        }




    }
}
