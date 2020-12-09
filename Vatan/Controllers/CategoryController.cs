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
            List<CategoryVM> model = _vatancontext.Categories.Where(q => q.Isdeleted == false).Select(q => new CategoryVM()
            {
                ID = q.ID,
                CategoryName = q.CategoryName,
                TopCategoryID= q.TopCategoryID,
         

            }).ToList();
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

        public IActionResult Edit(int id)
        {
            CategoryVM model = _vatancontext.Categories.Select(q => new CategoryVM()
            {
                ID = q.ID,
                CategoryName = q.CategoryName,
                TopCategoryID = q.TopCategoryID,
              

            }).FirstOrDefault(x => x.ID == id);

            return View(model);
        
        }

        [HttpPost]
        public IActionResult Edit(CategoryVM model)
        {
            Category category = _vatancontext.Categories.FirstOrDefault(x => x.ID == model.ID);

            if (ModelState.IsValid)
            {
                category.CategoryName = model.CategoryName;
        
                category.TopCategoryID = model.TopCategoryID;

                _vatancontext.SaveChanges();

            }
            return View();


        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Category category = _vatancontext.Categories.FirstOrDefault(x => x.ID == id);

            category.Isdeleted = true;

            _vatancontext.SaveChanges();

            return Json("Category Successfully Deleted!");
        }







    }
}
