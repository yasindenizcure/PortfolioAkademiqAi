using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultExperienceComponentPartial : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public _DefaultExperienceComponentPartial(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var experienceList = _appDbContext.Experiences.OrderByDescending(x=>x.ExperienceId).ToList();
            ViewBag.testimonials = _appDbContext.Testimonials.ToList();
            return View(experienceList);
        }
    }
}
