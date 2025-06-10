using Microsoft.AspNetCore.Mvc;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace UserManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Account == model.Account && u.Password == model.Password);

            if (user != null)
            {
                // 登入成功 → 儲存 UserId 到 Session
                HttpContext.Session.SetInt32("UserId", user.Id);
                return RedirectToAction("MyTasks", "WorkProgress");
            }

            ViewBag.Error = "帳號或密碼錯誤";
            return View();
        }
    }
}
