using Microsoft.AspNetCore.Mvc;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    public class AccountController : Controller
    {
       
        private readonly ApplicationDbContext _context; // Declare _context

        // Inject DbContext via constructor
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public IActionResult Login(string UserName, string Password)
        {
            var user = _context.Employees
                .FirstOrDefault(u => u.Username == UserName && u.Password == Password);

            if (user != null)
            {
                return RedirectToAction("Dashboard", new { id = user.Id });
            }

            ViewBag.Error = "Invalid username or password!";
            return View();
        }

        // GET: Dashboard
        public IActionResult Dashboard(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null) return NotFound();

            return View(employee);
        }

    }
}
