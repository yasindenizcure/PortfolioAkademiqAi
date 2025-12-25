using AkademiQPortfolio.Data;
using AkademiQPortfolio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly AppDbContext _context;

        public ExperienceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult ExperienceList()
        {
            var expList = _context.Experiences.ToList();
            return View(expList);
        }
        [HttpGet]
        public IActionResult CreateExperience() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            _context.Experiences.Add(experience);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        public IActionResult DeleteExperience(int id) 
        {
            var exp = _context.Experiences.Find(id);
            if (exp != null)
            {
                _context.Experiences.Remove(exp);
                _context.SaveChanges();
            }
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id) 
        {
            var exp = _context.Experiences.Find(id); 
            if (exp != null) 
            {
                return View(exp);
            }
            return RedirectToAction("ExperienceList");
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience exp) 
        {
            _context.Experiences.Update(exp);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
