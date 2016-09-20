using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pomodoro.Database;

namespace Pomodoro.Controllers
{
    public class HomeController : Controller
    {
        private readonly PomodoroContext _context;

        public HomeController(PomodoroContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Tomatoes);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tomato tomato)
        {
            if (ModelState.IsValid)
            {
                _context.Tomatoes.Add(tomato);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tomato);
        }



        public IActionResult Error()
        {
            return View();
        }
    }
}
