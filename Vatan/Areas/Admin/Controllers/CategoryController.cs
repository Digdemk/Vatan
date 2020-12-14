using Microsoft.AspNetCore.Mvc;
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
                TopCategory= _vatancontext.Categories.FirstOrDefault(x => x.ID == q.TopCategoryID).CategoryName


            }).ToList();
            return View(model);
            
        }

        public IActionResult Add()
        {
            CategoryVM model = new CategoryVM();
            model.categories = _vatancontext.Categories.ToList();
        
            return View(model);

         
        }
    

        [HttpPost]
        public IActionResult Add(CategoryVM model, int categoryid)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category();
                category.CategoryName = model.CategoryName;
                category.TopCategoryID = categoryid;

                _vatancontext.Categories.Add(category);
                _vatancontext.SaveChanges();
            }
            else
            {
                return View();
            }
            return RedirectToAction("Index", "Category");
       
           
        }

        public IActionResult Edit(int id)
        {


            CategoryVM model = _vatancontext.Categories.Select(q => new CategoryVM()
            {
                ID = q.ID,
                CategoryName = q.CategoryName,

                categories = _vatancontext.Categories.ToList()


            }).FirstOrDefault(x => x.ID == id);

            return View(model);
        
        }

        [HttpPost]
        public IActionResult Edit(CategoryVM model, int categoryid)
        {
            Category category = _vatancontext.Categories.FirstOrDefault(x => x.ID == model.ID);

            if (ModelState.IsValid)
            {
                category.CategoryName = model.CategoryName;
        
                category.TopCategoryID = categoryid;

                _vatancontext.SaveChanges();

            }
            else
            {
                return View(model);
            }

            return RedirectToAction("Index", "Category");


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
