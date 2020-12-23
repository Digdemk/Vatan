using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Areas.Admin.Models.ORM.Context;
using Vatan.Areas.Admin.Models.VM;

namespace Vatan.Controllers
{
    public class AnasayfaController : BaseeController
    {
        private readonly VatanContext _vatancontext;

        public AnasayfaController(VatanContext vatancontext, IMemoryCache memoryCache) : base(vatancontext, memoryCache)
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
    }
}
