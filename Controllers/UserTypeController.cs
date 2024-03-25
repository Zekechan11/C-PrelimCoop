using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mvczeke.Entities;

namespace mvczeke.Controllers
{
    public class UserTypeController : Controller
    {
        private readonly PelayoCoopContext _context;

        public UserTypeController(PelayoCoopContext context)
        {
            _context = context;
        }

       public IActionResult Index()
        {
            var model = _context.Usertypes.ToList();
            return View(model);
        }


         [HttpGet]

        public IActionResult Create()
        {
            var UserType = _context.Usertypes.ToList();
            ViewData["UserType"] = UserType;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Usertype b)
        {
            _context.Usertypes.Add(b);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

         [HttpGet]

        public IActionResult Update(int id)
        {
            var usertype = _context.Usertypes.Where(q => q.Id == id).FirstOrDefault();
            return View(usertype);
        }

        [HttpPost]
        public IActionResult Update(Usertype b)
        {
            _context.Usertypes.Update(b);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var usertype = _context.Usertypes.Where(q => q.Id == id).FirstOrDefault();
            _context.Usertypes.Remove(usertype);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}