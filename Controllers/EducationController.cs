using AkademiQPortfolio.Data;
using AkademiQPortfolio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class EducationController : Controller
    {
        private readonly AppDbContext _context;

        public EducationController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult EducationList()
        {
            var values = _context.Educations.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEducation(Education education) 
        {
            _context.Educations.Add(education);
            _context.SaveChanges();
            return RedirectToAction("EducationList");
        }
        public IActionResult DeleteEducation(int id)
        {
            var value = _context.Educations.Find(id);
            if (value != null)
            {
                _context.Educations.Remove(value);
                _context.SaveChanges();
            }
            return RedirectToAction("EducationList");
        }
        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var value = _context.Educations.Find(id);
            if (value != null)
            {
                return View(value);
            }
            return RedirectToAction("EducationList");
        }
        [HttpPost]
        public IActionResult UpdateEducation(Education education) 
        {
            _context.Educations.Update(education);
            _context.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
}
