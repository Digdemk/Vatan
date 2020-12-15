using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
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
    public class UserController : BaseController
    {
        private readonly VatanContext _vatancontext;

        public UserController(VatanContext vatancontext, IMemoryCache memoryCache) : base(vatancontext, memoryCache)
        {
            _vatancontext = vatancontext;
        }

        public IActionResult Index()
        {
            List<UserVM> users = _vatancontext.Users.Where(q => q.Isdeleted == false).Select(q => new UserVM()
            {
                ID = q.ID,
                Name = q.Name,
                Surname = q.Surname,
                Mail = q.Mail,
                Phone = q.Phone,
                Address = q.Address,
                Password=q.Password,

            }).ToList();

            return View(users);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(UserVM model)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.Mail = model.Mail;
                user.Password = model.Password;
                user.Address = model.Address;
                user.Phone = model.Phone;

                _vatancontext.Users.Add(user);
                _vatancontext.SaveChanges();
            }
            else
            {
                return View();
            }

            return RedirectToAction("Index", "User");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            User user = _vatancontext.Users.FirstOrDefault(x => x.ID == id);

            user.Isdeleted = true;

            _vatancontext.SaveChanges();

            return Json("User Successfully Deleted!");

        }
        public IActionResult Edit(int id)
        {
            UserVM model = _vatancontext.Users.Select(q => new UserVM()
            {

                ID = q.ID,
                Name = q.Name,
                Surname = q.Surname,
                Mail = q.Mail,
                Phone = q.Phone,
                Address = q.Address,
                Password = q.Password,

            }).FirstOrDefault(x => x.ID == id);


            return View(model);
        }


        [HttpPost]
        public IActionResult Edit(UserVM model)
        {
            User user = _vatancontext.Users.FirstOrDefault(x => x.ID == model.ID);

            if (ModelState.IsValid)
            {
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.Mail = model.Mail;
                user.Phone = model.Phone;
                user.Password = model.Password;
                user.Address = model.Address;

                _vatancontext.SaveChanges();
            }
            else
            {
                return View(model);
            }

            return RedirectToAction("Index", "User");
        }
    }
}
