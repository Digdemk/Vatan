using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
            List<ProductVM> movies = _vatancontext.Products.Include(x => x.ProductCategories).Include(q => q.Pictures).Where(q => q.Isdeleted == false).Select(q => new ProductVM()
            {
                ID = q.ID,
                ProductName = q.ProductName,
                Description = q.Description,
                Quantity = q.Quantity,
                Price = q.Price,
                
                  categories = q.ProductCategories.Where(q => q.Isdeleted == false).Select(q => q.Category).ToList(),
                MainImagePath = q.Pictures.Select(q => q.Path).ToList()


            }).ToList();

            return View(movies);

        }
        public IActionResult Add()
        {
            ProductVM model = new ProductVM();
            model.categoryCheck = _vatancontext.Categories.Select(q => new CategoryCheckVM()
            {
             
            categoryid = q.ID,
                IsChecked = false,
                Name = q.CategoryName

            }).ToArray();

            return View(model);
    }

        [HttpPost]
        public IActionResult Add(ProductVM model, int[] categoryArray)
        {
            List<string> paths = new List<string>();


            string imgpath = "";

            if (model.productimages != null)
            {
                foreach (var item in model.productimages)
                {

                    var guid = Guid.NewGuid().ToString();

                    var path = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "wwwroot/productimage", guid + ".jpg");
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        item.CopyTo(stream);
                    }

                    imgpath = guid + ".jpg";
                    paths.Add(imgpath);
                }

            }

            model.MainImagePath = paths;

            if (ModelState.IsValid)
            {
                Product product = new Product();
                product.ProductName = model.ProductName;
                product.Description = model.Description;
                product.Quantity = model.Quantity;
                product.Price = model.Price;

                _vatancontext.Products.Add(product);
                _vatancontext.SaveChanges();

              
               
                int authorid = product.ID;

                model.categories = _vatancontext.Categories.ToList();
                for (int i = 0; i < categoryArray.Length; i++)
                {
                    ProductCategory productategory = new ProductCategory();
                    productategory.CategoryId = categoryArray[i];
                    productategory.ProductId = authorid;
                    _vatancontext.ProductCategories.Add(productategory);

                }
                _vatancontext.SaveChanges();

                int productid = product.ID;

                foreach (var item in model.MainImagePath)
                {
                    Picture image = new Picture();
                    image.Path = item;
                    image.ProductId = productid;

                    _vatancontext.Pictures.Add(image);
                }

                _vatancontext.SaveChanges();




            }

            else
            {
                model.categoryCheck = _vatancontext.Categories.Select(q => new CategoryCheckVM()
                {

                    categoryid = q.ID,
                    IsChecked = false,
                    Name = q.CategoryName

                }).ToArray();

                return View(model);
            }
            return RedirectToAction("Index", "Product");


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
            //ProductVM model = _vatancontext.Products.Select(q => new ProductVM()
            //{
            //    ID = q.ID,
            //    ProductName = q.ProductName,
            //    Description = q.Description,
            //    Quantity = q.Quantity,
            //    Price = q.Price,
            //    categories = _vatancontext.Categories.ToList()


            //}).FirstOrDefault(x => x.ID == id);

            //return View(model);



            Product author = _vatancontext.Products.FirstOrDefault(x => x.ID == id);
            List<CategoryCheckVM> categoryChecks = new List<CategoryCheckVM>();

            ProductVM model = new ProductVM();
            model.ProductName = author.ProductName;
            model.Description = author.Description;
            model.Quantity = author.Quantity;
            model.Price = author.Price;

            model.categories = _vatancontext.Categories.ToList();
            //model.categoryid = _newscontext.AuthorCategories.Where(q => q.AuthorID == id).Select(q => q.CategoryID).ToArray();
            int[] selectedCategories = _vatancontext.ProductCategories.Where(q => q.Isdeleted == false).Where(q => q.ProductId == id).Select(q => q.CategoryId).ToArray();

            foreach (var item in model.categories)
            {
                CategoryCheckVM categoryCheck = new CategoryCheckVM();
                categoryCheck.categoryid = item.ID;


                foreach (var item2 in selectedCategories)
                {
                    if (item2 == categoryCheck.categoryid)
                    {
                        categoryCheck.IsChecked = true;
                        break;
                    }
                    else
                    {
                        categoryCheck.IsChecked = false;
                    }

                }

                categoryCheck.Name = item.CategoryName;

                categoryChecks.Add(categoryCheck);
            }

            model.categoryCheck = categoryChecks.ToArray();

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
        public IActionResult Detail(int id)
        {




            //Product author = _vatancontext.Products.Include(q => q.ProductCategories).ThenInclude(q => q.Category).FirstOrDefault(x => x.ID == id);
            //ProductVM model = new ProductVM();

            //model.Price = author.Price;
            //model.ProductName = author.ProductName;
            //model.Quantity = author.Quantity;
            //model.Description = author.Description;

            //return Json(model);

            ProductVM movies = _vatancontext.Products.Include(x => x.ProductCategories).Where(q => q.Isdeleted == false).Select(q => new ProductVM()
            {
                ID = q.ID,
                ProductName = q.ProductName,
                Description = q.Description,
                Quantity = q.Quantity,
                Price = q.Price,
                //categories = q.ProductCategories.Where(a => a.Isdeleted == false).Select(q => q.Category).ToList()
                categories = q.ProductCategories.Where(q => q.Isdeleted == false).Select(q => q.Category).ToList()

            }).FirstOrDefault(q => q.ID == id);

            return Json(movies);
        }
    }
}
