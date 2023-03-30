using Microsoft.AspNetCore.Mvc;
using Nhap.Models;
using Nhap.Models.ViewModel;

namespace Nhap.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly LoginCoreContext context;

        public AccountController(LoginCoreContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dangnhap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Dangnhap(dangky model)
        {
            return View();
        }
        public IActionResult Dangky() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Dangky(dangkyuser model)
        { 
            if (ModelState.IsValid)
            {
                var data = new UserDb()
                {
                    UserName= model.UserName,
                    Password= model.Password,
                    Email= model.Email,
                    Address= model.Address,
                    Brithday= model.Brithday,
                   FullName= model.FullName,
                };
                context.UserDbs.Add(data);
                context.SaveChanges();
                TempData["successMessage"] = "You are eligible to login, please fill on ....."
                return RedirectToAction("Đăng nh");
            }
            else
            {
                TempData["errorMessage"] = "Biễu mẫu không được để trống!";
                return View(model);
            }
           
        }
    }
}
