using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Linq;

public class WorkProgressController : Controller
{
    private readonly AppDbContext _context;

    public WorkProgressController(AppDbContext context)
    {
        _context = context;
    }

    // GET: /WorkProgress
    public async Task<IActionResult> Index()
    {
        var list = await _context.WorkProgresses.Include(wp => wp.User).ToListAsync();
        return View(list);
    }
    public IActionResult MyTasks()
    {
        var userId = HttpContext.Session.GetInt32("UserId");

        if (userId == null)
        {
            return RedirectToAction("Index", "Login");
        }

        var myTasks = _context.WorkProgresses
            .Include(w => w.User)
            .Where(w => w.UserId == userId)
            .ToList();

        return View("Index", myTasks); // 重用 Index.cshtml 畫面
    }

}
