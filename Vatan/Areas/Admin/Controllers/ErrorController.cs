using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Areas.Admin.Models.ORM.Context;

namespace Vatan.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ErrorController : BaseController
    {
        private readonly VatanContext _vatancontext;

        public ErrorController(VatanContext vatancontext, IMemoryCache memoryCache) : base(vatancontext, memoryCache)
        {
            _vatancontext = vatancontext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
