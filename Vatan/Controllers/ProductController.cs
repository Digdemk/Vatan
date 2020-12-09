using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Models.ORM.Context;
using Vatan.Models.ORM.Entities;
using Vatan.Models.VM;

namespace Vatan.Controllers
{
    public class ProductController : Controller
    {
        private readonly VatanContext _vatancontext;

        public ProductController(VatanContext vatanContext)
        {
            _vatancontext = vatanContext;
        }

        public IActionResult Index()
        {
            List<ProductVM> movies = _vatancontext.Products.Include(x => x.ProductCategories).Where(q => q.Isdeleted == false).Select(q => new ProductVM()
            {
                ID = q.ID,
                ProductName = q.ProductName,
                Description = q.Description,
                Quantity = q.Quantity,
                Price = q.Price,
                categories = q.ProductCategories.Where(a => a.Isdeleted == false).Select(q => q.Category).ToList()

            }).ToList();

            return View(movies);

        }
        public IActionResult Add()
        {
            ProductVM model = new ProductVM();
            model.categories = _vatancontext.Categories.ToList();

            return View(model);

        }

        [HttpPost]
        public IActionResult Add(ProductVM model, int[] categoryArray)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product();
                product.ProductName = model.ProductName;
                product.Description = model.Description;
                product.Quantity = model.Quantity;
                product.Price = model.Price;

                _vatancontext.Products.Add(product);
                _vatancontext.SaveChanges();

                int ID = product.ID;

                foreach (var item in categoryArray)
                {
                    ProductCategory productCategory = new ProductCategory();
                    productCategory.ProductId = ID;
                    productCategory.CategoryId = item;

                    _vatancontext.ProductCategories.Add(productCategory);
                }
                _vatancontext.SaveChanges();


                return RedirectToAction("Index", "Product");
            }

            else
            {
                return View();

            }


        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Product product = _vatancontext.Products.FirstOrDefault(x => x.ID == id);

            product.Isdeleted = true;

            _vatancontext.SaveChanges();

            return Json("Product Successfully Deleted!");
        }

        public IActionResult Edit(int id)
        {
            ProductVM model = _vatancontext.Products.Select(q => new ProductVM()
            {
                ID = q.ID,
                ProductName = q.ProductName,
                Description = q.Description,
                Quantity = q.Quantity,
                Price = q.Price,
                categories = _vatancontext.Categories.ToList()


            }).FirstOrDefault(x => x.ID == id);

            return View(model);

        }

        [HttpPost]
        public IActionResult Edit(ProductVM model, int[] categoryArray)
        {
            Product product = _vatancontext.Products.FirstOrDefault(x => x.ID == model.ID);

            if (ModelState.IsValid)
            {
                product.ProductName = model.ProductName;
                product.Description = model.Description;
                product.Quantity = model.Quantity;
                product.Price = model.Price;


                _vatancontext.SaveChanges();

 
                List<ProductCategory> productCategory = _vatancontext.ProductCategories.Where(f => f.ProductId == model.ID).ToList();
                productCategory.ForEach(a => a.Isdeleted = true);
                _vatancontext.SaveChanges();
                

                foreach (var item in categoryArray)
                {
                    ProductCategory productCategory3 = new ProductCategory();
                    productCategory3.ProductId = model.ID;
                    productCategory3.CategoryId = item;

                    _vatancontext.ProductCategories.Add(productCategory3);
                }
                _vatancontext.SaveChanges();




                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View();
            }




        }
    }
}
