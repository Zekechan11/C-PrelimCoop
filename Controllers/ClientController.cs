using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvczeke.Entities;

namespace mvczeke.Controllers
{
    public class ClientController : Controller
    {
        private readonly PelayoCoopContext _context;

        public ClientController(PelayoCoopContext client)
        {
            _context = client;
        }

        public IActionResult Index()
        {
            var client = _context.ClientInfos.ToList();
            return View(client);
        }

        [HttpGet]

        public IActionResult Create()
        {
            var UserType = _context.Usertypes.ToList();
            ViewData["UserType"] = UserType;
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClientInfo b)
        {
            _context.ClientInfos.Add(b);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Update(int id)
        {
            var usertype = _context.Usertypes.ToList();
            var clientInfo = _context.ClientInfos.FirstOrDefault(q => q.Id == id);
            ViewData["UserTypes"] = usertype;
            return View(clientInfo);
        }

        [HttpPost]
        public IActionResult Update(ClientInfo b)
        {
            _context.ClientInfos.Update(b);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var clientInfo = _context.ClientInfos.Where(q => q.Id == id).FirstOrDefault();
            _context.ClientInfos.Remove(clientInfo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}