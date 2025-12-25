using AkademiQPortfolio.Data;
using AkademiQPortfolio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var abouts = _context.Abouts.ToList();
            return View(abouts);
        }
        [HttpGet]
        public IActionResult CreateAbout() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(About about) 
        {
            _context.Abouts.Add(about);
            _context.SaveChanges();
            return RedirectToAction("Index", "About");
        }
        public IActionResult DeleteAbout(int id) 
        {
            var value = _context.Abouts.Find(id);
            if(value != null)
            {
                _context.Abouts.Remove(value);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "About");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id) 
        {
            var value = _context.Abouts.Find(id);
            if(value != null)
            {
                return View(value);
            }
            return RedirectToAction("Index", "About");
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about) 
        {
            _context.Abouts.Update(about);
            _context.SaveChanges();
            return RedirectToAction("Index", "About");
        }
    }
}
