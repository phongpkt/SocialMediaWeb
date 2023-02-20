using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebDemo.Data;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class IdeasController : Controller
    {
        private readonly ApplicationDbContext context;
        public IdeasController(ApplicationDbContext _context)
        {
            context = _context;

        }
        public IActionResult Index()
        {
            var idea = context.Ideas.ToList();
            return View(idea);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var idea = context.Ideas
                .FirstOrDefault(m => m.IdeasId == id);
            return View(idea);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Ideas idea)
        {
            if (ModelState.IsValid)
            {
                context.Ideas.Add(idea);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(idea);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var idea = context.Ideas.Find(id);
            context.Ideas.Remove(idea);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
