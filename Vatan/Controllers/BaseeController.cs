using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Areas.Admin.Models.ORM.Context;
using Vatan.Areas.Admin.Models.ORM.Entities;

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

            ViewBag.menu2 = menu;
            base.OnActionExecuting(context);

           
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }
    }
}
