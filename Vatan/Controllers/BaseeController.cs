using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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
    public class BaseeController : Controller
    {
        private readonly VatanContext _vatancontext;
        private readonly IMemoryCache _memoryCache;

        public BaseeController(VatanContext vatancontext, IMemoryCache memoryCache)
        {
            _vatancontext = vatancontext;
            _memoryCache = memoryCache;


        }


        public override void OnActionExecuting(ActionExecutingContext context)
        {
            List<OnyuzCategoryVM> model = _vatancontext.Categories.Where(q => q.Isdeleted == false&& q.TopCategoryID<1).Select(q => new OnyuzCategoryVM()
            {
                ID = q.ID,
                CategoryName = q.CategoryName,

                categories = _vatancontext.Categories.Where(x => x.TopCategoryID == q.ID).ToList()


            }).ToList();
            List<Category> menu = new List<Category>();
         
            bool isExist = _memoryCache.TryGetValue("menus", out menu);

            if (!isExist)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                    .SetSlidingExpiration(TimeSpan.FromSeconds(60));

                menu = _vatancontext.Categories.ToList();

                _memoryCache.Set("menus", menu, cacheEntryOptions);
            }

            ViewBag.menu2 = model;
            base.OnActionExecuting(context);

           
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }
    }
}
