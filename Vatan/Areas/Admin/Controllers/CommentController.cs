using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class CommentController : Controller
    {
        private readonly VatanContext _vatancontext;

        public CommentController(VatanContext vatanContext)
        {
            _vatancontext = vatanContext;
        }

        public IActionResult Index()
        {
            List<CommentVM> model = _vatancontext.Comments.Where(q => q.Isdeleted == false).Include(q=> q.User).Include(q=> q.Product).Select(q => new CommentVM()
            {
                ID = q.ID,
                Title = q.Title,
                Description = q.Description,
                UserName = q.User.Name,
                ProductName = q.Product.ProductName,
                AddDate = q.AddDate,
             
            }).ToList();

            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Comment comment = _vatancontext.Comments.FirstOrDefault(x => x.ID == id);

            comment.Isdeleted = true;

            _vatancontext.SaveChanges();

            return Json("Comment Successfully Deleted!");
        }
    }
}
