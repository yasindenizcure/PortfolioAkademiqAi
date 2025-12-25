using AkademiQPortfolio.Data;
using AkademiQPortfolio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly AppDbContext _context;

        public ProjectsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult ProjectList()
        {
            var context = _context.Projects.ToList();
            return View(context);
        }
        [HttpGet]
        public IActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProject(Project prj)
        {
            _context.Projects.Add(prj);
            _context.SaveChanges();
            return RedirectToAction("ProjectList");
        }
        public IActionResult DeleteProject(int id)
        {
            var value = _context.Projects.Find(id);
            if (value != null)
            {
                _context.Projects.Remove(value);
                _context.SaveChanges();
            }
            return RedirectToAction("ProjectList");
        }
        [HttpGet]
        public IActionResult UpdateProject(int id)
        {
            var value = _context.Projects.Find(id);
            if (value != null)
            {
                return View(value);
            }
            return RedirectToAction("ProjectList");
        }
        [HttpPost]
        public IActionResult UpdateProject(Project projects)
        {
            _context.Projects.Update(projects);
            _context.SaveChanges();
            return RedirectToAction("ProjectList");

        }
    }
}
