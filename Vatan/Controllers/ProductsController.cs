using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Areas.Admin.Models.ORM.Context;
using Vatan.Areas.Admin.Models.ORM.Entities;
using Vatan.Areas.Admin.Models.VM;

namespace Vatan.Controllers
{
    public class ProductsController : BaseeController
    {
        private readonly VatanContext _vatancontext;

        public ProductsController(VatanContext vatancontext, IMemoryCache memoryCache) : base(vatancontext, memoryCache)
        {
            _vatancontext = vatancontext;
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
        public IActionResult Category(int id)
        {
            //List<Ca> movies = _vatancontext.Products.Include(x => x.ProductCategories).Include(q => q.Pictures).Where(q => q.Isdeleted == false).Select(q => new ProductVM()
            //{
            //    ID = q.ID,
            //    ProductName = q.ProductName,
            //    Description = q.Description,
            //    Quantity = q.Quantity,
            //    Price = q.Price,

            //    categories = q.ProductCategories.Where(q => q.Isdeleted == false).Select(q => q.Category).ToList(),
            //    MainImagePath = q.Pictures.Select(q => q.Path).ToList()


            //}).ToList();
            OnyuzProductVM movies = _vatancontext.Categories.Include(x => x.ProductCategories).ThenInclude(ProductCategories => ProductCategories.Product).ThenInclude(x => x.Pictures).Select(q => new OnyuzProductVM()
            {
                ID = q.ID,
                products= q.ProductCategories.Where(q => q.Isdeleted == false).Select(q => q.Product).ToList(),

            }).FirstOrDefault(q => q.ID == id);

            return View(movies);
          
        }

        public IActionResult Detail(int id)
        {
            ProductVM movies = _vatancontext.Products.Include(x => x.ProductCategories).Include(q => q.Pictures).Where(q => q.Isdeleted == false).Select(q => new ProductVM()
            {
                ID = q.ID,
                ProductName = q.ProductName,
                Description = q.Description,
                Quantity = q.Quantity,
                Price = q.Price,

                categories = q.ProductCategories.Where(q => q.Isdeleted == false).Select(q => q.Category).ToList(),
                MainImagePath = q.Pictures.Select(q => q.Path).ToList()


            }).FirstOrDefault(q => q.ID == id);

            return View(movies);

            
        }


        }
}
