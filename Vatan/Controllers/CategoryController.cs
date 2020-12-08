using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Models.ORM.Context;
using Vatan.Models.ORM.Entities;
using Vatan.Models.VM;

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

        [HttpPost]
        public IActionResult Add(CategoryVM model)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category();
                category.CategoryName = model.CategoryName;
                category.TopCategoryID = model.TopCategoryID;

                _vatancontext.Categories.Add(category);
                _vatancontext.SaveChanges();
            }

            return View();
        }




    }
}
