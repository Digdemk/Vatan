using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Areas.Admin.Models.ORM.Context;
using Vatan.Areas.Admin.Models.ORM.Entities;

namespace Vatan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BaseController : Controller
    {
        private readonly VatanContext _vatancontext;
        private readonly IMemoryCache _memoryCache;

        public BaseController(VatanContext vatancontext, IMemoryCache memoryCache)
        {
            _vatancontext = vatancontext;
            _memoryCache = memoryCache;
        }


        public override void OnActionExecuting(ActionExecutingContext context)
        {
            List<AdminMenu> menu = new List<AdminMenu>();

            bool isExist = _memoryCache.TryGetValue("menus", out menu);

            if (!isExist)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                    .SetSlidingExpiration(TimeSpan.FromSeconds(60));

                menu = _vatancontext.AdminMenus.ToList();

                _memoryCache.Set("menus", menu, cacheEntryOptions);
            }

            ViewBag.menu = menu;
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }
    }
}
