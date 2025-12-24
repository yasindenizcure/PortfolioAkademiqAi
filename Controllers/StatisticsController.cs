using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly AppDbContext _context;

        public StatisticsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult StatisticsCards()
        {
            var messageCount= _context.Messages.Count();
            var messageCountByIsReadTrue = _context.Messages.Where(x=> x.IsRead == true).Count();
            var messageCountByIsReadFalse = _context.Messages.Where(x=> x.IsRead == false).Count();
            var skillCount = _context.Skills.Count();
            var skillAvgValue = _context.Skills.Average(x=> x.SkillValue);
            var skillValueBiggerThan70= _context.Skills.Where(x=> x.SkillValue >= 70).Count();

            ViewBag.messageCount = messageCount;
            ViewBag.messageCountByIsReadTrue = messageCountByIsReadTrue;
            ViewBag.messageCountByIsReadFalse = messageCountByIsReadFalse;
            ViewBag.skillCount = skillCount;
            ViewBag.skillAvgValue = skillAvgValue;
            ViewBag.skillValueBiggerThan70 = skillValueBiggerThan70;

            return View();
        }
    }
}
