using AkademiQPortfolio.Data;
using AkademiQPortfolio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class SkillController : Controller
    {
        private readonly AppDbContext _context;

        public SkillController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult SkillList()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        public IActionResult DeleteSkill(int id)
        {
            var value = _context.Skills.Find(id);
            if (value != null)
            {
                _context.Skills.Remove(value);
                _context.SaveChanges();
            }
            return RedirectToAction("SkillList");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = _context.Skills.Find(id);
            if (value != null)
            {
                return View(value);
            }
            return RedirectToAction("SkillList");
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            var value = _context.Skills.Find(skill.SkillId);
            if (value != null)
            {
                value.SkillTitle = skill.SkillTitle;
                value.SkillValue = skill.SkillValue;
                _context.SaveChanges();
            }
            return RedirectToAction("SkillList");

        }
    }
}
