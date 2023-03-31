using CNPMNC.Data;
using CNPMNC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNPMNC.Controllers
{
    public class AdminController : Controller
    {
        private readonly RaoVatDbContext _context;

        public AdminController(RaoVatDbContext context)
        {
            _context = context;
        }
        //GET: Admin
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginAdmin(Admin admin)
        {

            var check = _context.Admins.Where(s => s.adminName.Equals(admin.adminName) && s.adminPassword.Equals(admin.adminPassword)).FirstOrDefault();
            if (check == null)
            {
                ViewBag.ErrorInfo = "Sai thông tin";
                return View("Index");
            }
            else
            {
                HttpContext.Session.SetString("adminName", check.adminName.ToString());
                HttpContext.Session.SetString("adminPassword", check.adminPassword.ToString());
                return RedirectToAction("Index", "Home");

            }

        }

        public ActionResult LogoutAdmin()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
